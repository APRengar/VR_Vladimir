using UnityEngine;
using TMPro;

public class Keyboard : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private GameObject normalButtons;
    [SerializeField] private GameObject capsButtons;
    private bool caps;

    //We want on a start caps to be off
    void Start()
    {
        caps = false;    
    }

    // function to add character into the displayed text
    public void InsertCharacter(string c)
    {
        inputField.text += c;
    }

    // function to delete laast character  like a backspace
    public void DeleteChar()
    {
        if (inputField.text.Length > 0)
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
        }
    }

    //function to add space into displayed text
    public void InsertSpace()
    {
        inputField.text += " ";
    }

    //function to switch CAPS
    public void SwitchCaps()
    {
        if (!caps)
        {
            normalButtons.SetActive(false);
            capsButtons.SetActive(true);
            caps = true;
        }
        else
        {
            normalButtons.SetActive(true);
            capsButtons.SetActive(false);
            caps = false;
        }
    }

}
