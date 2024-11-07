using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public bool IsStart = false;
    Button currentButton;
    // Start is called before the first frame update
    void Start()
    {
        currentButton = GameObject.Find("StartButton").GetComponent<Button>();
        currentButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonClick()
    {
        Vector3 cameraPosition = Camera.main.transform.position;
        cameraPosition.x = 0;
        cameraPosition.y = 0;
        Camera.main.transform.position = cameraPosition;
        IsStart = true;
    }
}
