using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PistolButtonHandle : MonoBehaviour
{
    public Button currentButton;
    public CommonBuyButton _commonBuyButton = new CommonBuyButton();

    // Start is called before the first frame update
    void Start()
    {
        currentButton = GameObject.Find("PistolButton").GetComponent<Button>();
        currentButton.onClick.AddListener(OnButtonClick);

        _commonBuyButton.InitInterface<Pistol>(currentButton, "Pistol_Store", "PistolButton");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonClick()
    {
        _commonBuyButton.OnClickButton<Pistol>("Pistol_Store", "PistolButton", 100);
    }
}
