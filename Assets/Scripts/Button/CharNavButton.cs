using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharNavButton : MonoBehaviour
{
    // Start is called before the first frame update
    Button currentButton;
    void Start()
    {
        currentButton = GameObject.Find("CharacterStore").GetComponent<Button>();
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
        cameraPosition.y = -20;
        Camera.main.transform.position = cameraPosition;
    }
}
