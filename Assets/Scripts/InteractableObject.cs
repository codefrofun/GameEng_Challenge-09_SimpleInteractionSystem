using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;


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

    public InfoUIController infoUIController;  // Reference to the InfoUIController script
    public Text interactionTextUI;  // Reference to the Text UI component

    public void Interact()
    {

        switch (interactableType)
        {
            case InteractableType.Hint:
                // Handle hint interaction (show hint message)
                ShowInteractionText("Hint: " + interactionText);
                break;


            case InteractableType.Info:
                //Handle info interaction(show text above the player)
                ShowInteractionText("Info: " + interactionText);
                break;


            case InteractableType.Pickup:
                // Handle pickup interaction (Item will get destroyed)
                ShowInteractionText("Picked up: " + interactionText);
                if (itemToPickup != null)
                {
                    Destroy(itemToPickup); // Remove the object from the scene
                }
                break;
        }
    }

    private void ShowInteractionText(string message)
    {
        if (interactionTextUI != null)
        {
            interactionTextUI.text = message;  // Set the text of the UI Text component
        }
    }
}
