using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveButton : MonoBehaviour
{
    public GameObject LeftBtn;
    public GameObject RightBtn;
    public GameObject UpBtn;
    public GameObject DownBtn;

    int i = 1;
    int j = 1;

    void Update()
    {
        switch (Map.PlayerPlace)
        {
            case (int)Places.WITCH_HOUSE:
                if ((i == 1 && j == 2) || (i == 1 && j == 3) || (i == 2 && j == 2) || (i == 3 && j == 2))
                    LeftBtn.SetActive(true);
                else
                    LeftBtn.SetActive(false);
                if ((i == 1 && j == 1) || (i == 1 && j == 2) || (i == 2 && j == 1) || (i == 3 && j == 1))
                    RightBtn.SetActive(true);
                else
                    RightBtn.SetActive(false);
                if ((i == 1 && j == 1) || (i == 1 && j == 2) || (i == 2 && j == 1) || (i == 2 && j == 2))
                    UpBtn.SetActive(true);
                else
                    UpBtn.SetActive(false);
                if ((i == 2 && j == 1) || (i == 2 && j == 2) || (i == 3 && j == 1) || (i == 3 && j == 2))
                    DownBtn.SetActive(true);
                else
                    DownBtn.SetActive(false);
                break;
            case (int)Places.SANTA_HOUSE:
                if ((i == 1 && j == 2) || (i == 1 && j == 3) || (i == 2 && j == 3) || (i == 3 && j == 3))
                    LeftBtn.SetActive(true);
                else
                    LeftBtn.SetActive(false);
                if ((i == 1 && j == 1) || (i == 1 && j == 2) || (i == 2 && j == 2) || (i == 3 && j == 2))
                    RightBtn.SetActive(true);
                else
                    RightBtn.SetActive(false);
                if ((i == 1 && j == 2) || (i == 1 && j == 3) || (i == 2 && j == 2) || (i == 2 && j == 3))
                    UpBtn.SetActive(true);
                else
                    UpBtn.SetActive(false);
                if ((i == 2 && j == 2) || (i == 2 && j == 3) || (i == 3 && j == 2) || (i == 3 && j == 3))
                    DownBtn.SetActive(true);
                else
                    DownBtn.SetActive(false);
                break;
        }
    }

    public void LeftBtnClicked()
    {
        j--;

        if (Map.PlayerPlace == (int)Places.DAYCARE)
        {
            LeftBtn.SetActive(false);
            RightBtn.SetActive(true);
        }
    }

    public void RightBtnClicked()
    {
        j++;

        if (Map.PlayerPlace == (int)Places.DAYCARE)
        {
            LeftBtn.SetActive(true);
            RightBtn.SetActive(false);
        }
    }

    public void UpBtnClicked()
    {
        i++;
    }

    public void DownBtnClicked()
    {
        i--;
    }
}