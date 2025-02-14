using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendingMachine : MonoBehaviour
{

    [SerializeField] GameObject vmMenu; // vending machine menu canvas

    private Transform player;
    public float openRadius = 3; //Player has to be within radius to open chest

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    //When player clicks on vending machine
    private void OnMouseDown()
    {
        // second condition avoids opening the vm menu through the pause menu
        if (Vector2.Distance(player.position, transform.position) <= openRadius && Time.timeScale != 0)
        {
            vmMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    // resume game and exit vm menu
    public void Resume()
    {
        vmMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
