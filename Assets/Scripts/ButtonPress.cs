using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{

    public GameObject txtToDisplay;             //display the UI text 1


    private bool PlayerInZone;                  //check if the player is in trigger

    public GameObject lightorobj;
    public GameObject lightorobj2;

    private void Start()
    {

        PlayerInZone = false;                   //player not in zone       
        txtToDisplay.SetActive(false);
    }

    public void Update()
    {
        if (PlayerInZone && Input.GetMouseButtonDown(0))            //if in zone and press Left Click

        {
            lightorobj.SetActive(!lightorobj.activeSelf);
            lightorobj2.SetActive(!lightorobj.activeSelf);
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<Animator>().Play("switch");
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