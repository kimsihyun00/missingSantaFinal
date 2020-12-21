using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject LeftBtn;
    public GameObject RightBtn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GameOverPanel.SetActive(true); 
            LeftBtn.SetActive(false);
            RightBtn.SetActive(false);
            SledGame.SledClear = false;

            Time.timeScale = 0;
        }
    }
}
