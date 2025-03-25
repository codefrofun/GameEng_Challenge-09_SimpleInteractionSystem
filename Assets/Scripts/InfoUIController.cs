using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUIController : MonoBehaviour
{
    public Text infoText;        // Reference to the UI Text component.
    public float displayTime = 3f; // Time to display the text before it disappears.

    public void ShowInfo(string message)
    {
        infoText.text = message;
        infoText.gameObject.SetActive(true);

        StartCoroutine(HideInfoAfterTime());

    }

    private IEnumerator HideInfoAfterTime()
    {
        yield return new WaitForSeconds(displayTime);  // Wait for the displayTime
        infoText.gameObject.SetActive(false);  // Hide the text
    }
}
