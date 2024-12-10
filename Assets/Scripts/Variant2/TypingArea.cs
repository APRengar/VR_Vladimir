using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TypingArea : MonoBehaviour
{
    [SerializeField] GameObject leftHand;
    [SerializeField] GameObject rightHand;
    [SerializeField] GameObject leftTypingHand;
    [SerializeField] GameObject rightTypingHand;

    private void OnTriggerEnter(Collider other) 
    {
        GameObject hand = other.GetComponent<XRDirectInteractor>().gameObject;
        if (hand == null)
            return;
        if (hand == leftHand)
        {

        }
    }
}
