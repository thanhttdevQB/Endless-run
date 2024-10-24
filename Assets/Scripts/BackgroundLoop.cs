using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float speed = 5f;              
    public float resetPosition = -20f;      
    public GameObject secondBackground;
    public bool isRunning = true;

    private float backgroundWidth;          

    void Start()
    {
        if (secondBackground == null)
        {
            Debug.LogError("secondBackground is not assigned!");
            return;
        }
       
        backgroundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        Debug.Log(isRunning);
        if (isRunning)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            secondBackground.transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (transform.position.x < resetPosition)
            {
                transform.position = new Vector3(secondBackground.transform.position.x + backgroundWidth, transform.position.y, transform.position.z);
            }

            if (secondBackground.transform.position.x < resetPosition)
            {
                secondBackground.transform.position = new Vector3(transform.position.x + backgroundWidth, secondBackground.transform.position.y, secondBackground.transform.position.z);
            }
            //UIManager.instance.bnGameOverr.SetActive(true);
        }
    }
}
