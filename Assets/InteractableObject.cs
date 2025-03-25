using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum InteractableType
{
    Hint,
    Info,
    Pickup
}

public class InteractableObject : MonoBehaviour
{
    public InteractableType interactableType;
    public string interactionText;  // Text that appears when interacted with.
    public GameObject itemToPickup;

    public void Interact()
    {
        switch (interactableType)
        {
            case InteractableType.Hint:
                // Handle hint interaction (show hint message)
                Debug.Log("Hint: " + interactionText);
                break;


            case InteractableType.Info:
                // Handle info interaction (show text above the player)
                Debug.Log("Info: " + interactionText);
                break;


            case InteractableType.Pickup:
                // Handle pickup interaction (add to inventory and disable object)
                Debug.Log("Picked up: " + interactionText);
                if (itemToPickup != null)
                {
                    Destroy(itemToPickup); // Remove the object from the scene
                }
                break;
        }

    }
}
