using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSelect : MonoBehaviour
{
    public GameObject ClearBtn;
    public GameObject GameOverPanel;

    public GameObject[] SkullClosedImages;
    public GameObject[] SkullOpenedImages;

    public Sprite InBoxNothing;
    public Sprite InBoxCoin;

    int rand = -1;

    private void Start()
    {
        rand = Random.Range(0, 5);
    }

    public void SkullBox1Clicked()
    {
        checkBox(0);
    }

    public void SkullBox2Clicked()
    {
        checkBox(1);
    }

    public void SkullBox3Clicked()
    {
        checkBox(2);
    }
    
    public void SkullBox4Clicked()
    {
        checkBox(3);
    }

    public void SkullBox5Clicked()
    {
        checkBox(4);
    }

    void checkBox(int index)
    {
        if (rand == index)
        {
            SkullGame.SkullClear = true;
            SkullClosedImages[index].SetActive(false);
            SkullOpenedImages[index].SetActive(true);
            SkullOpenedImages[index].GetComponent<Image>().sprite = InBoxCoin;
        }
        else
        {
            SkullGame.SkullClear = false;
            SkullClosedImages[index].SetActive(false);
            SkullOpenedImages[index].SetActive(true);
            SkullOpenedImages[index].GetComponent<Image>().sprite = InBoxNothing;
            SkullClosedImages[rand].SetActive(false);
            SkullOpenedImages[rand].SetActive(true);
            SkullOpenedImages[rand].GetComponent<Image>().sprite = InBoxCoin;
        }

        StartCoroutine(GameEndPanel());
    }

    IEnumerator GameEndPanel()
    {
        yield return new WaitForSeconds(1f);

        if (SkullGame.SkullClear)
            ClearBtn.SetActive(true);
        else
            GameOverPanel.SetActive(true);
    }
}
