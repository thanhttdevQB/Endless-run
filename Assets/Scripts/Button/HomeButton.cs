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
        currentButton = GameObject.Find("Home").GetComponent<Button>();
        currentButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        Vector3 cameraPosition = Camera.main.transform.position;
        cameraPosition.x = 70;
        cameraPosition.y = -20;
        Camera.main.transform.position = cameraPosition;
        Debug.Log(Camera.main.transform.position);
    }
}
