using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUIController : MonoBehaviour
{
    public Text infoText;         // Reference to the UI Text component.
    public float displayTime = 3f; // Time to display the text before it disappears.

    public void ShowInfo(string message)
    {
        infoText.text = message;

    }
}
