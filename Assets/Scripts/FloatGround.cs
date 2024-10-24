using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatGround : MonoBehaviour
{
    float GroundY;
    float GroundHeight;
    float objectY;

    private BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GroundY = GameObject.Find("matdat1").transform.position.y;
        GroundHeight = GameObject.Find("matdat1").GetComponent<BoxCollider2D>().size.y;
        objectY = GameObject.Find("Player").transform.position.y;
        Debug.Log("objectY" + objectY);
        Debug.Log("ground" + (GroundY + GroundHeight));

        if (objectY >= (GroundY + GroundHeight))
        {
            boxCollider.enabled = true;
        }
        if (objectY < (GroundY + GroundHeight))
        {
            boxCollider.enabled = false;
        }
    }
}
