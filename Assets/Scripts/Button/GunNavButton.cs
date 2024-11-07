using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GunNavButton : MonoBehaviour
{
    // Start is called before the first frame update
    Button currentButton;
    void Start()
    {
        currentButton = GameObject.Find("GunMenu").GetComponent<Button>();
        currentButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnButtonClick()
    {
        Debug.Log("sdfsdf");
        Vector3 cameraPosition = Camera.main.transform.position;
        cameraPosition.x = 40;
        cameraPosition.y = -20;
        Camera.main.transform.position = cameraPosition;
    }
}
