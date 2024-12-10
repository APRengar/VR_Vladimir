using TMPro;
using UnityEngine;

public class KeyboardButton : MonoBehaviour
{
    private Keyboard keyboard;
    private TextMeshProUGUI buttonText;

    void Start()
    {
        keyboard = GetComponentInParent<Keyboard>();
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        if (buttonText.text.Length == 1)
        {
            //get text from the button name and attach keyboard as a listner of that character.
            NameToButtonText();
            GetComponentInChildren<ButtonVR>().onRelease.AddListener(delegate {keyboard.InsertCharacter(buttonText.text);});
        }
    }

    // set the text from a button name;
    private void NameToButtonText()
    {
        buttonText.text = gameObject.name;
    }
}
