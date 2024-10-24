using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SniperButtonHandle : MonoBehaviour
{
    public Button currentButton;
    public CommonBuyButton _commonBuyButton = new CommonBuyButton();

    // Start is called before the first frame update
    void Start()
    {
        currentButton = GameObject.Find("SniperButton").GetComponent<Button>();
        currentButton.onClick.AddListener(OnButtonClick);

        _commonBuyButton.InitInterface<Sniper>(currentButton, "Sniper_Store", "SniperButton");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonClick()
    {
        _commonBuyButton.OnClickButton<Sniper>("Sniper_Store", "SniperButton", 300);
    }
}
