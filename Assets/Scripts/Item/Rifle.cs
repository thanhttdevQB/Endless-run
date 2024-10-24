using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    public int color { get; set; } = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = color == 1 ? Color.white : Color.black;

        //PlayerPrefs.SetInt("Pistol_Store", 0);
        //PlayerPrefs.SetInt("Sniper_Store", 0);
        //PlayerPrefs.SetInt("Rifle_Store", 0);

        //PlayerPrefs.SetInt("MaskDude_Store", 0);
        //PlayerPrefs.SetInt("NinjaFrog_Store", 0);
        //PlayerPrefs.SetInt("PinkMan_Store", 0);
    }
}
