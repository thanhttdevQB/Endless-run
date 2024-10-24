using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Collide : MonoBehaviour
{
    public int Heart = 3;
    public int Coin = 0;
    public TextMeshProUGUI CoinText;
    public TextMeshProUGUI HeartText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CoinText.SetText(Coin.ToString());
        HeartText.SetText(Heart.ToString());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Coin++;
            // Get and set gia tri vinh vien
            /*PlayerPrefs.SetInt("Coin", Coin);
            int coin = PlayerPrefs.GetInt("Coin");*/
            CoinText.SetText(Coin.ToString());
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Trap"))
        {
            Heart--;
            HeartText.SetText(Heart.ToString());
            Destroy(collision.gameObject);
        }
    }

}
