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
    public void OnClickButton<ScriptName>(string objName, string buttonName, int moneyAmount) where ScriptName : MonoBehaviour
    {
        if (PlayerPrefs.GetInt(objName) == 1)
        {
            string[] gunsType = { "Rifle", "Pistol", "Sniper" };
            string[] character = { "MaskDude", "PinkMan", "NinjaFrog" };
            string[] selected = gunsType.Contains(objName) ? gunsType : character;
            foreach (string element in selected)
            {
                if (element != objName && PlayerPrefs.GetInt(element) == 2)
                {
                    PlayerPrefs.SetInt(element, 1);
                    string currentButtonName = element + "Button";
                    //GameObject currentButton = GameObject.Find(currentButtonName);
                    //Debug.Log(currentButton == null);
                    //currentButton.SetActive(true);
                    ChangeText("Equip", currentButtonName);
                }
            }
            GameObject button = GameObject.Find(buttonName);
            PlayerPrefs.SetInt(objName, 2);
            ChangeText("Equiped", buttonName);
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
        }
    }

    public void ChangeText(string text, string buttonName)
    {
        GameObject button = GameObject.Find(buttonName);
        Button fullButton = button.GetComponent<Button>();
        TextMeshProUGUI tmpText = fullButton.GetComponentInChildren<TextMeshProUGUI>();
        tmpText.text = text;
    }

    public void ChangeColor<ScriptName>(string objName)
    {
        GameObject Obj = GameObject.Find(objName);
        PropertyInfo propertyInfo = typeof(ScriptName).GetProperty("color");
        FieldInfo fieldInfo = typeof(ScriptName).GetField("color");

        //if (fieldInfo != null)
        //{
        //    Debug.Log("Field color found");
        //}
        //else
        //{
        //    Debug.LogError("Field color not found");
        //    return;
        //}

        if (Obj == null)
        {
            Debug.Log(objName);
        }
        else
        {
            Debug.Log("nothing wrong");
        }
        object value = 1;
        propertyInfo.SetValue(Obj.GetComponent<ScriptName>(), value);
    }
}
