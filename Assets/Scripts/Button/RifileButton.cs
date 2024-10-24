using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class RifileButtonHandle : MonoBehaviour
{
    public Button currentButton;
    public CommonBuyButton _commonBuyButton = new CommonBuyButton();

    // Start is called before the first frame update
    void Start()
    {
        currentButton = GameObject.Find("RifleButton").GetComponent<Button>();
        currentButton.onClick.AddListener(OnButtonClick);

        _commonBuyButton.InitInterface<Rifle>(currentButton, "Rifle_Store", "RifleButton");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonClick()
    {
        _commonBuyButton.OnClickButton<Rifle>("Rifle_Store", "RifleButton", 200);
    }
}
