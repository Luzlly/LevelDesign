using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndText : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject player;
    public GameObject endcam;

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
            player.SetActive(!obj3.activeSelf);
            endcam.SetActive(!obj3.activeSelf);
            GameObject.Find("Main Camera").GetComponent<AudioListener>().enabled = false;
            GameObject.Find("EndCamera").GetComponent<AudioListener>().enabled = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
