using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string Level;
    public void LoadLevel()
        {
            SceneManager.LoadScene(Level);
        }
    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                LoadLevel();
            }
        }
    }
