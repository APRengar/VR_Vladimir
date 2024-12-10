using TMPro;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;

public class ShowKeyboard : MonoBehaviour
{
    //inputfield to interact with and print the text
    private TMP_InputField inputField;

    //assigh events
    private void Start() 
    {
        inputField = GetComponent<TMP_InputField>();
        inputField.onSelect.AddListener(x => OpenKeyboard());
        inputField.onDeselect.AddListener(x => CloseKeyboard());
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

    //function to show caret on selected and hide caret on close
    private void SetCaretColor(float value)
    {
        inputField.customCaretColor = true;
        Color caretColor = inputField.caretColor;
        caretColor.a = value;
        inputField.caretColor = caretColor;
    }
}
