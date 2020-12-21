using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calendar : MonoBehaviour
{
    // Calendar Panel Handle
    public Image CalImage;
    public Sprite[] CalSprites = new Sprite[3];
    public GameObject[] CalLeftRight = new GameObject[2];

    int month = 12;

    public void CalBtnClicked()
    {
        month = 12;
        CalMonthChange();
    }

    public void LeftBtnClicked()
    {
        month--;
        if (month < 10)
            month = 10;
        CalMonthChange();
    }

    public void RightBtnClicked()
    {
        month++;
        if (month > 12)
            month = 12;
        CalMonthChange();
    }

    void CalMonthChange()
    {
        switch (month)
        {
            case 12:
                CalImage.sprite = CalSprites[0];
                CalLeftRight[0].SetActive(true);
                CalLeftRight[1].SetActive(false);
                break;
            case 11:
                CalImage.sprite = CalSprites[1];
                CalLeftRight[0].SetActive(true);
                CalLeftRight[1].SetActive(true);
                break;
            case 10:
                CalImage.sprite = CalSprites[2];
                CalLeftRight[0].SetActive(false);
                CalLeftRight[1].SetActive(true);
                break;
        }
    }
}
