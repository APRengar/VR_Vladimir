using TMPro;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;



public class NewBehaviourScript : MonoBehaviour
{
    //here we select in the inspector where the text apppear
    [SerializeField] TMP_InputField inputField;

    //this inputfield is an easy way as placeholder to activate keyboard
    private TMP_InputField activator;

    //assigh events
    private void Start() 
    {
        activator = GetComponent<TMP_InputField>();
        activator.onSelect.AddListener(x => OpenKeyboard());
        activator.onDeselect.AddListener(x => CloseKeyboard());
    }

    //open keyboard
    public void OpenKeyboard()
    {
        NonNativeKeyboard.Instance.InputField = inputField;
        NonNativeKeyboard.Instance.PresentKeyboard(inputField.text);
        SetCaretColor(1);
    }

    //close keyboard
    public void CloseKeyboard()
    {
        NonNativeKeyboard.Instance.Close();
        SetCaretColor(0);
    }

    private void SetCaretColor(float value)
    {
        inputField.customCaretColor = true;
        Color caretColor = inputField.caretColor;
        caretColor.a = value;
        inputField.caretColor = caretColor;
    }
}
