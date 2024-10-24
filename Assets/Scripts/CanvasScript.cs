using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject scence1;
    GameObject scence2;
    void Start()
    {
        scence1 = GameObject.Find("Scence1");
        scence2 = GameObject.Find("Scence2");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = Camera.main.transform.position;
        if (cameraPosition.x != 80)
        {
            scence1.SetActive(false);
        } else
        {
            scence1.SetActive(true);
        }

        if (cameraPosition.x != 50)
        {
            scence2.SetActive(false);
        }
        else
        {
            scence2.SetActive(true);
        }

        //Debug.Log(cameraPosition.x);
    }
}
