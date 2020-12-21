using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum MainBtns
{
    CAL,
    HINT,
    NOTE,
    BAG,
    MAP
};

public class MainButton : MonoBehaviour
{
    // All Buttons Handle
    public GameObject[] BtnPanels = new GameObject[5];
    public static int BtnNum = -1;

    private void Awake()
    {
        BtnNum = -1;
    }

    public void CalBtnClicked()
    {
        if (BtnNum == -1)
        {
            BtnNum = (int)MainBtns.CAL;
            BtnPanels[BtnNum].SetActive(true);
        }
    }


    public void HintBtnClicked()
    {
        if (BtnNum == -1)
        {
            BtnNum = (int)MainBtns.HINT;
            BtnPanels[BtnNum].SetActive(true);
        }
    }

    public void NoteBtnClicked()
    {
        if (BtnNum == -1)
        {
            BtnNum = (int)MainBtns.NOTE;
            BtnPanels[BtnNum].SetActive(true);
        }
    }

    public void BagBtnClicked()
    {
        if (BtnNum == -1)
        {
            BtnNum = (int)MainBtns.BAG;
            BtnPanels[BtnNum].SetActive(true);
        }
    }

    public void MapBtnClicked()
    {
        if (BtnNum == -1)
        {
            BtnNum = (int)MainBtns.MAP;
            BtnPanels[BtnNum].SetActive(true);
        }
    }

    public void CloseBtnClicked()
    {
        if (BtnNum != -1)
        {
            BtnPanels[BtnNum].SetActive(false);
            BtnNum = -1;
        }
    }
}
