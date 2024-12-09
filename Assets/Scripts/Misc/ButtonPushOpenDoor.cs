using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushOpenDoor : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string boolName = "Open";

    private void Start() 
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ToggleDoor());
    }

    public void ToggleDoor()
    {
        bool isOpen = animator.GetBool(boolName);
        animator.SetBool(boolName, !isOpen);
    }
}
