using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaskDudeButton : MonoBehaviour
{
    Button currentButton;
    public CommonBuyButton _commonBuyButton = new CommonBuyButton();
    // Start is called before the first frame update
    void Start()
    {
        currentButton = GameObject.Find("MaskDudeButton").GetComponent<Button>();
        currentButton.onClick.AddListener(OnButtonClick);

        _commonBuyButton.InitInterface<MaskDude>(currentButton, "MaskDude_Store", "MaskDudeButton");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonClick()
    {
        _commonBuyButton.OnClickButton<MaskDude>("MaskDude_Store", "MaskDudeButton", 100);
    }
}
