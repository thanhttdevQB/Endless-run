using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinkManBuyButton : MonoBehaviour
{
    Button currentButton;
    public CommonBuyButton _commonBuyButton = new CommonBuyButton();
    // Start is called before the first frame update
    void Start()
    {
        currentButton = GameObject.Find("PinkManButton").GetComponent<Button>();
        currentButton.onClick.AddListener(OnButtonClick);

        _commonBuyButton.InitInterface<PinkMan>(currentButton, "PinkMan_Store", "PinkManButton");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonClick()
    {
        _commonBuyButton.OnClickButton<PinkMan>("PinkMan_Store", "PinkManButton", 100);
    }
}
