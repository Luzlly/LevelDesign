using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOff : MonoBehaviour
{

    public GameObject txtToDisplay;             //display the UI text 1

    private bool PlayerInZone;                  //check if the player is in trigger

    private void Start()
    {

        PlayerInZone = false;                   //player not in zone       
        txtToDisplay.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")     //if player in zone
        {
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
        }
    }


    private void OnTriggerExit(Collider other)     //if player exit zone
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }
}