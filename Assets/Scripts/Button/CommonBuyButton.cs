using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Button = UnityEngine.UI.Button;

public class CommonBuyButton
{
    public Sprite newSprite;

    public void OnClickButton<ScriptName>(string objName, string buttonName, int moneyAmount) where ScriptName : MonoBehaviour
    {
        if (PlayerPrefs.GetInt(objName) == 1)
        {
            string[] gunsType = { "Rifle_Store", "Pistol_Store", "Sniper_Store" };
            string[] character = { "MaskDude_Store", "PinkMan_Store", "NinjaFrog_Store" };
            string[] selected = gunsType.Contains(objName) ? gunsType : character;
            foreach (string element in selected)
            {
                if (element != objName && PlayerPrefs.GetInt(element) == 2)
                {
                    PlayerPrefs.SetInt(element, 1);
                    string currentButtonName = element.Replace("_Store", "") + "Button";
                    ChangeText("Equip", currentButtonName);
                }
            }
            GameObject button = GameObject.Find(buttonName);
            PlayerPrefs.SetInt(objName, 2);
            ChangeText("Equiped", buttonName);
            ChangeGun(objName);
        }
        if (PlayerPrefs.GetInt(objName) != 1 && PlayerPrefs.GetInt(objName) != 2)
        {
            GameObject Obj = GameObject.Find(objName);
            Color white = Color.white;
            var MoneyAmount = 400;
            object value = 1;
            if (MoneyAmount >= moneyAmount)
            {
                //button.SetActive(false);
                ChangeColor<ScriptName>(objName);
                ChangeText("Equip", buttonName);
                MoneyAmount -= moneyAmount;
                PlayerPrefs.SetInt(objName, 1);
            }
        } 
    }

    public void InitInterface<ScriptName>(Button myButton, string objName, string buttonName) where ScriptName : MonoBehaviour
    {
        Button fullButton = myButton.GetComponent<Button>();
        if (PlayerPrefs.GetInt(objName) == 1)
        {
            ChangeColor<ScriptName>(objName);
            ChangeText("Equip", buttonName);
        }
        if (PlayerPrefs.GetInt(objName) == 2)
        {
            ChangeColor<ScriptName>(objName);
            ChangeText("Equipped", buttonName);
            ChangeGun(objName);
        }
    }

    public void ChangeText(string text, string buttonName)
    {
        GameObject button = GameObject.Find(buttonName);
        Button fullButton = button.GetComponent<Button>();
        TextMeshProUGUI tmpText = fullButton.GetComponentInChildren<TextMeshProUGUI>();
        tmpText.text = text;
    }

    public void ChangeGun(string GunName)
    {
        GameObject Gun = GameObject.Find("Pistol");
        GameObject NewGun = GameObject.Find(GunName);
        newSprite = NewGun.GetComponent<SpriteRenderer>().sprite;
        Gun.GetComponent<SpriteRenderer>().sprite = newSprite;
        if (GunName == "Sniper_Store")
        {
            Gun.transform.localPosition = new Vector3(1f, -0.6f, 0f);
            Gun.transform.localScale = new Vector3(3f, 3.174202f, 1f);
        }
        else if (GunName == "Pistol_Store")
        {
            Gun.transform.localPosition = new Vector3(0.79f, -0.416f, 0f);
            Gun.transform.localScale = new Vector3(3.796407f, 3.174202f, 1f);
        }
        else
        {
            Gun.transform.localPosition = new Vector3(1.06f, -0.431f, 0f);
            Gun.transform.localScale = new Vector3(3.087997f, 3.024697f, 1f);
        }
    }

    public void ChangeColor<ScriptName>(string objName)
    {
        GameObject Obj = GameObject.Find(objName);
        PropertyInfo propertyInfo = typeof(ScriptName).GetProperty("color");
        object value = 1;
        propertyInfo.SetValue(Obj.GetComponent<ScriptName>(), value);
    }
}
