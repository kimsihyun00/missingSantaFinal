using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVisible : MonoBehaviour
{
    public GameObject ObjectPanel;

    public GameObject[] Objects1;
    public GameObject[] Objects2;
    public GameObject[] Objects3;

    int MoveIndex = -1;
    int i = 0;
    int j = 0;

    private void Start()
    {
        i = 0;
        j = 0;
    }

    void Update()
    {
        if (Objects2.Length == 0)
        {
            if (Objects1.Length == 2)
            {
                switch (j)
                {
                    case 0:
                        Objects1[0].SetActive(true);
                        Objects1[1].SetActive(false);
                        break;
                    case 1:
                        Objects1[0].SetActive(false);
                        Objects1[1].SetActive(true);
                        break;
                }
            }
            else
                Objects1[0].SetActive(true);
        }
        else
        {
            if (i == 0)
                for (int k = 0; k < Objects1.Length; k++)
                {
                    if (j == k)
                        Objects1[k].SetActive(true);
                    else
                        Objects1[k].SetActive(false);

                    Objects2[k].SetActive(false);
                    Objects3[k].SetActive(false);
                }

            if (i == 1)
                for (int k = 0; k < Objects2.Length; k++)
                {
                    if (j == k)
                        Objects2[k].SetActive(true);
                    else
                        Objects2[k].SetActive(false);

                    Objects1[k].SetActive(false);
                    Objects3[k].SetActive(false);
                }

            if (i == 2)
                for (int k = 0; k < Objects3.Length; k++)
                {
                    if (j == k)
                        Objects3[k].SetActive(true);
                    else
                        Objects3[k].SetActive(false);

                    Objects1[k].SetActive(false);
                    Objects2[k].SetActive(false);
                }

        }

        if (i == 1 && j == 1)
            Objects2[1].SetActive(true);
    }

    public void LeftBtnClicked()
    {
        MoveIndex = 0;
        StartCoroutine(WaitToChange());
    }

    public void RightBtnClicked()
    {
        MoveIndex = 1;
        StartCoroutine(WaitToChange());
    }

    public void UpBtnClicked()
    {
        MoveIndex = 2;
        StartCoroutine(WaitToChange());
    }

    public void DownBtnClicked()
    {
        MoveIndex = 3;
        StartCoroutine(WaitToChange());
    }

    IEnumerator WaitToChange()
    {
        yield return new WaitForSeconds(1f);

        switch(MoveIndex)
        {
            case 0:
                j--;
                break;
            case 1:
                j++;
                break;
            case 2:
                i++;
                break;
            case 3:
                i--;
                break;
        }
    }
}
