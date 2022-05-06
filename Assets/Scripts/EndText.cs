using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndText : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            obj1.SetActive(!obj1.activeSelf);
            obj2.SetActive(!obj2.activeSelf);
            obj3.SetActive(!obj3.activeSelf);
            GameObject.Find("Player").GetComponent<FPSMovement>().enabled = false;
            GameObject.Find("Player").GetComponent<HeadBob>().StopBobbing();
            GameObject.Find("Player").GetComponent<HeadBob>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
            GameObject.Find("Player").GetComponent<CharacterController>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
