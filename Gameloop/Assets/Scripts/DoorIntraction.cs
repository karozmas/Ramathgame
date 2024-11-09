using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class DoorInteraction : MonoBehaviour
{
    public GameObject door;
    public GameObject interactionText;
    public string sceneToLoad; // Name of the scene to load
    private bool playerNearby = false;

    void Start()
    {
        interactionText.SetActive(false); // Hide text initially
    }

    void Update()
    {
        if (playerNearby && Keyboard.current.rKey.wasPressedThisFrame)
        {
            OpenDoor();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
            interactionText.SetActive(true); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
            interactionText.SetActive(false); 
        }
    }

    private void OpenDoor()
    {
        interactionText.SetActive(false); 
        SceneManager.LoadScene(sceneToLoad);
    }
}
