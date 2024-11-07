using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject scence1;
    GameObject scence2;
    GameObject MainMenu;
    GameObject Home;
    void Start()
    {
        scence1 = GameObject.Find("Scence1");
        scence2 = GameObject.Find("Scence2");
        MainMenu = GameObject.Find("MainMenu");
        Home = GameObject.Find("Home");
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 cameraPosition = Camera.main.transform.position;
        if (cameraPosition.x != 40 || cameraPosition.y != -20)
        {
            scence1.SetActive(false);
        } else
        {
            scence1.SetActive(true);
        }

        if (cameraPosition.x != 0 || cameraPosition.y != -20)
        {
            scence2.SetActive(false);
        }
        else
        {
            scence2.SetActive(true);
        }

        if ((cameraPosition.x != 0 && cameraPosition.y != -20) || (cameraPosition.x != 40 && cameraPosition.y != -20))
        {
            Home.SetActive(false);
        }
        else
        {
            Home.SetActive(true);
        }

        CanvasGroup canvasGroup = MainMenu.GetComponent<CanvasGroup>();
        if (cameraPosition.x == 70 && cameraPosition.y == -20)
        {
            canvasGroup.alpha = 1;  // Hide by making it transparent
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        } else
        {
            canvasGroup.alpha = 0f;  // Hide by making it transparent
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        }

        Debug.Log(cameraPosition.x);
    }
}
