using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public float speed = 5f;               // Tốc độ cuộn của nền
    public float resetPosition = -1000f;   // Vị trí khi nền cần reset về bên phải
    public float startPosition = 20f;      // Vị trí bắt đầu lại của nền (bên phải màn hình)
    public bool isRunning = true;          // Kiểm soát nền có cuộn hay không
    private float backgroundWidth;         // Chiều rộng của nền
    public GameObject StartButton;

    void Start()
    {
        backgroundWidth = GetComponent<SpriteRenderer>().bounds.size.x; // Lấy chiều rộng của nền để tính toán reset vị trí
    }
    void Update()
    {
        StartButton = GameObject.Find("StartButton");
        bool isStart;
        if (StartButton == null)
        {
            isStart = true;
        }
        else
        {
            StartButton = GameObject.Find("StartButton");
            StartButton startButton = StartButton.GetComponent<StartButton>();
            isStart = startButton.IsStart;
        }
        if (isStart != false)
        {
            Debug.Log(isRunning);
            if (isRunning)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);// Di chuyển nền sang trái theo tốc độ xác định
                if (transform.position.x < resetPosition)// Nếu nền ra khỏi màn hình (vị trí nhỏ hơn resetPosition), reset nó về vị trí bắt đầu (startPosition)
                {
                    transform.position = new Vector3(startPosition, transform.position.y, transform.position.z);
                }
            }
        }
    }
}
