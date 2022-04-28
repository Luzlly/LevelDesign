using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public GameObject txtToDisplay;             //display the UI text

    private bool PlayerInZone;                  //check if the player is in trigger

    public GameObject lightorobj;

    public GameObject lightorobj1;

    public GameObject lightorobj2;

    public GameObject lightorobj3;


    private void Start()
    {

        PlayerInZone = false;                   //player not in zone       
        txtToDisplay.SetActive(false);
    }

    private void Update()
    {
        if (PlayerInZone && Input.GetMouseButtonDown(0))           //if in zone and press Left Click
        {
            gameObject.GetComponent<AudioSource>().Play();
            txtToDisplay.SetActive(false);
            lightorobj.SetActive(!lightorobj.activeSelf);
            lightorobj1.SetActive(!lightorobj1.activeSelf);
            lightorobj2.SetActive(!lightorobj2.activeSelf);
            lightorobj3.SetActive(!lightorobj3.activeSelf);
        }
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