using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;
    public float TimeBtwFire = 0.2f;
    public float bulletForce;

    private float timeBtwFire;
    void Update()
    {

        timeBtwFire -= Time.deltaTime;
        if (Input.GetMouseButton(0) && timeBtwFire < 0)
        {
            FireBullet();
        }



    }
    void FireBullet()
    {
        timeBtwFire = TimeBtwFire;
        GameObject bulletTmp = Instantiate(bullet, firePos.position, Quaternion.identity);
        Rigidbody2D rb = bulletTmp.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * bulletForce, ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
   
    
        if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
        }
    }

}

   
