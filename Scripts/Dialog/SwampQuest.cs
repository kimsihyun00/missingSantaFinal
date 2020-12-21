using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwampQuest : MonoBehaviour
{
    public GameObject SwampBefore;
    public GameObject SwampAfter;

    public GameObject SwampPopUpPanel;

    public static bool SwampClicked = false;

    private void Start()
    {
        if (SwampClicked)
            SwampBefore.SetActive(false);
    }

    public void SwampBeforeBtnClicked()
    {
        if (AnswerNote.Chapter >= 2)
        {
            SwampClicked = true;
            SwampBefore.SetActive(false);
            SwampAfter.SetActive(true);
        }
    }

    public void SwampAfterBtnClicked()
    {
        SwampPopUpPanel.SetActive(true);
    }

    public void SwampPopUpBtnClicked()
    {
        SceneManager.LoadScene("SkullGameScene");
    }

    public void SwampPopUpCloseBtnClicked()
    {
        SwampPopUpPanel.SetActive(false);
    }
}
