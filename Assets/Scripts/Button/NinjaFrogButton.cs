using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NinjaFrogBuyButton : MonoBehaviour
{
    Button currentButton;
    public CommonBuyButton _commonBuyButton = new CommonBuyButton();
    // Start is called before the first frame update
    void Start()
    {
        currentButton = GameObject.Find("NinjaFrogButton").GetComponent<Button>();
        currentButton.onClick.AddListener(OnButtonClick);

        _commonBuyButton.InitInterface<NinjaFrog>(currentButton, "NinjaFrog", "NinjaFrogButton");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonClick()
    {
        _commonBuyButton.OnClickButton<NinjaFrog>("NinjaFrog", "NinjaFrogButton", 100);
    }
}
