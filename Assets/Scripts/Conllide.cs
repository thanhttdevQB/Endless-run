using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.Experimental.GraphView;

public class Collide : MonoBehaviour
{

    public int Heart = 1;
    public int Coin = 0;
    public int Kill = 0;
    public TextMeshProUGUI CoinText;
    public TextMeshProUGUI HeartText;
    public TextMeshProUGUI KillText;

    public GameObject BG;

    public static Collide instance;

    void Start()
    {
        BG = GameObject.Find("BG");
    }

    void Update()
    {
        CoinText.SetText(Coin.ToString());
        HeartText.SetText(Heart.ToString());
        KillText.SetText(Kill.ToString());
        if (Heart <= 0)
        {
            GameOver();
        }
    }
    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    public void AddKill(int amount)
    {
        Kill += amount;
        KillText.SetText(Kill.ToString());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemies"))
        {
            AddKill(1);
            Heart--;
            HeartText.SetText(Heart.ToString());
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Coin"))
        {
            Coin++;
            // Get and set gia tri vinh vien
            /*PlayerPrefs.SetInt("Coin", Coin);
            int coin = PlayerPrefs.GetInt("Coin");*/
            CoinText.SetText(Coin.ToString());
            Destroy(collision.gameObject);
        }

    }
    void GameOver()
    {
        if (!BG.GetComponent<BackgroundLoop>().isRunning)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
