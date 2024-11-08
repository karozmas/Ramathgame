using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using TMPro;

public class Instructions : MonoBehaviour
{


  //  public TextMeshProUGUI controlsText;   // Text object for controls instructions
    public TextMeshProUGUI mainTaskText;   // Text object for main task

    private void Start()
    {
        // Set the initial text for controls and main task
       // controlsText.text = "Controls:\nMove: WASD\nInteract: E\nInventory: I\nRun: Shift";
        mainTaskText.text = "Task:\n Find the secret room.";

        // Start coroutine to hide controlsText after 5 seconds
        //StartCoroutine(HideControlsAfterDelay(5f));
    }

    private System.Collections.IEnumerator HideControlsAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
       // controlsText.gameObject.SetActive(false);  // Hide controls instructions after the delay
    }
}



