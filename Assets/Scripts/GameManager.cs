using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject StartButton;
    public virtual void GameOver()
    {
        SceneManager.LoadScene("Level1");
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
    }

    public void EndGame()
    {
        StartButton = GameObject.Find("StartButton");
        StartButton startButton = StartButton.GetComponent<StartButton>();
        startButton.IsStart = false;

        Vector3 cameraPosition = Camera.main.transform.position;
        cameraPosition.x = 70;
        cameraPosition.y = -20;
        Camera.main.transform.position = cameraPosition;

        SceneManager.LoadScene("Level1");
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
    }
}
