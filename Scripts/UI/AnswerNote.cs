using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerNote : MonoBehaviour
{
    // Answer Note Panel Handle
    public GameObject NotePanel;

    public GameObject[] Pages = new GameObject[4];

    public GameObject LeftButton;
    public GameObject RightButton;

    public GameObject Chapter2Lock;
    public GameObject Chapter3Lock;
    
    public static int Chapter = 1;

    public GameObject[] ScrollBars = new GameObject[10];
    int[] ScrollValues = new int[10];

    public void RightBtnClicked()
    {
        LeftButton.SetActive(true);
        RightButton.SetActive(false);
        Pages[0].SetActive(false);
        Pages[1].SetActive(false);
        Pages[2].SetActive(true);
        Pages[3].SetActive(true);

        switch (Chapter)
        {
            case 1:
                Chapter2Lock.SetActive(true);
                Chapter3Lock.SetActive(true);
                break;
            case 2:
                Chapter2Lock.SetActive(false);
                Chapter3Lock.SetActive(true);
                break;
            case 3:
                Chapter2Lock.SetActive(false);
                Chapter3Lock.SetActive(false);
                ScrollBars[4].GetComponent<Scrollbar>().value = 0.2f;
                ScrollBars[5].GetComponent<Scrollbar>().value = 0f;
                ScrollBars[6].GetComponent<Scrollbar>().value = 0.6f;
                ScrollBars[7].GetComponent<Scrollbar>().value = 0.8f;
                break;
        }

    }

    public void LeftBtnClicked()
    {
        LeftButton.SetActive(false);
        RightButton.SetActive(true);
        Pages[0].SetActive(true);
        Pages[1].SetActive(true);
        Pages[2].SetActive(false);
        Pages[3].SetActive(false);
    }


    public void SelectBtnClicked()
    {
        
        switch(Chapter)
        {
            case 1:
                for (int i = 0; i < 4; i++)
                    ScrollValues[i] = (int)(ScrollBars[i].GetComponent<Scrollbar>().value * 10);
                if (ScrollValues[0] == 6 && ScrollValues[1] == 0 && ScrollValues[2] == 8 && ScrollValues[3] == 4)
                {
                    Chapter = 2;
                    Chapter2Lock.SetActive(false);
                    Chapter3Lock.SetActive(true);
                    NotePanel.SetActive(false);
                    SceneManager.LoadScene("Chapter1Scene");
                }
                break;
            case 2:
                for (int i = 4; i < 8; i++)
                    ScrollValues[i] = (int)(ScrollBars[i].GetComponent<Scrollbar>().value * 10);
                if (ScrollValues[4] == 2 && ScrollValues[5] == 0 && ScrollValues[6] == 6 && ScrollValues[7] == 8)
                {
                    Chapter = 3;
                    Chapter2Lock.SetActive(false);
                    Chapter3Lock.SetActive(false);
                    NotePanel.SetActive(false);
                    SceneManager.LoadScene("Chapter2Scene");
                }
                break;
            case 3:
                ScrollValues[8] = (int)(ScrollBars[8].GetComponent<Scrollbar>().value * 10);
                ScrollValues[9] = (int)(ScrollBars[9].GetComponent<Scrollbar>().value * 10);
                if (ScrollValues[8] == 4 && ScrollValues[9] == 2)
                {
                    Chapter = 4;
                    NotePanel.SetActive(false);
                    SceneManager.LoadScene("Chapter3Scene");
                }
                break;
        }
    }

    public void NoteBtnClicked()
    {
        switch (Chapter)
        {
            case 2:
                ScrollBars[0].GetComponent<Scrollbar>().value = 0.6f;
                ScrollBars[1].GetComponent<Scrollbar>().value = 0f;
                ScrollBars[2].GetComponent<Scrollbar>().value = 0.8f;
                ScrollBars[3].GetComponent<Scrollbar>().value = 0.4f;
                break;
            case 3:
                ScrollBars[0].GetComponent<Scrollbar>().value = 0.6f;
                ScrollBars[1].GetComponent<Scrollbar>().value = 0f;
                ScrollBars[2].GetComponent<Scrollbar>().value = 0.8f;
                ScrollBars[3].GetComponent<Scrollbar>().value = 0.4f;
                ScrollBars[4].GetComponent<Scrollbar>().value = 0.2f;
                ScrollBars[5].GetComponent<Scrollbar>().value = 0f;
                ScrollBars[6].GetComponent<Scrollbar>().value = 0.6f;
                ScrollBars[7].GetComponent<Scrollbar>().value = 0.8f;
                break;
            default:
                break;
        }
    }
}
