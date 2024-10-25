using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeButton : MonoBehaviour
{
    Button currentButton;
    // Start is called before the first frame update
    void Start()
    {
        currentButton = GameObject.Find("HomeButton").GetComponent<Button>();
        currentButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        
        Vector3 cameraPosition = Camera.main.transform.position;
        if(cameraPosition.x == 80 || cameraPosition.x == 50)
        {
            cameraPosition.x = 0;
            Camera.main.transform.position = cameraPosition;
        }
        else
        {
            cameraPosition.x = 80;
            Camera.main.transform.position = cameraPosition;
        }
    }
}
