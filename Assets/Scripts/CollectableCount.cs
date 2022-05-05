using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCount : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    public int count;
    

    // Start is called before the first frame update
    void Start()
    {
        count = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (count == 4 )
        {
            obj1.SetActive(!obj1.activeSelf);
            obj2.SetActive(!obj2.activeSelf);
            obj3.SetActive(!obj3.activeSelf);
            count++;
        }
    }
}
