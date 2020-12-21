using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WitchQuest : MonoBehaviour
{
    public GameObject WitchBefore;
    public GameObject WitchAfter;

    public GameObject WitchPopUpPanel;

    public static bool WitchClicked = false;
 
    private void Start()
    {
        if (WitchClicked)
            WitchBefore.SetActive(false);
    }

    public void WitchBeforeBtnClicked()
    {
        if (AnswerNote.Chapter >= 3)
        {
            WitchClicked = true;
            WitchBefore.SetActive(false);
        }
    }

    public void WitchAfterBtnClicked()
    {
        if (!DialogManager.Talking)
        {
            WitchPopUpPanel.SetActive(true);
        }
    }

    public void WitchPopUpBtnClicked()
    {
        SceneManager.LoadScene("PotionGameScene");
    }

    public void WitchPopUpCloseClicked()
    {
        WitchPopUpPanel.SetActive(false);
    }
}
