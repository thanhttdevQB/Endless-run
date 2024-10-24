using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    private bool isfacingRight = true;
    private float left_right;
    public GameObject BG;

    public float jumpForce;  // The force of the jump
    public bool isGrounded = true;

    private Rigidbody2D rb;
    private Animator ani;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        BG = GameObject.Find("BG1");
    }

    void Update()
    {
        left_right = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(left_right * speed, rb.velocity.y);
        ani.SetFloat("move", Mathf.Abs(left_right));
        turn_around();
        float positionY = GameObject.Find("Player").transform.position.y;
        if (positionY < -5)
        {
            BG.GetComponent<BackgroundLoop>().isRunning = false;
        }
        GameOver();
    }
    void turn_around()
    {
        if (isfacingRight && left_right < 0 || !isfacingRight && left_right > 0)
        {
            isfacingRight = !isfacingRight;
            Vector3 size = transform.localScale;
            size.x = size.x * -1;
            transform.localScale = size;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MatDat"))
        {
            if (Input.GetKey("up"))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("VatCan"))  // Check if the character collides with a rock
        {
            BG.GetComponent<BackgroundLoop>().isRunning = false;
            rb.velocity = new Vector2(rb.velocity.x, -1 * jumpForce);
        }
    }

    void GameOver()
    {
        //if (rb.position.y < -10 || !BG.GetComponent<BackgroundLoop>().isRunning)
        //{
        //    FindObjectOfType<GameManager>().EndGame();
        //}
    }
}



