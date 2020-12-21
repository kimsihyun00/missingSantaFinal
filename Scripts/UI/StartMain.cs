using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMain : MonoBehaviour
{
    public GameObject MethodPanel;
    public GameObject CreditPanel;

    bool clicked = false;

    public void StartBtnClicked()
    {
        SceneManager.LoadScene("OpeningScene");
    }

    public void MethodBtnClicked()
    {
        if (!clicked)
        {
            clicked = true;
            MethodPanel.SetActive(true);
        }
    }

    public void MethodCloseBtnClicked()
    {
        clicked = false;
        MethodPanel.SetActive(false);
    }

    public void CreditBtnClicked()
    {
        if (!clicked)
        {
            clicked = true;
            CreditPanel.SetActive(true);
        }
    }

    public void CreditCloseBtnClicked()
    {
        clicked = false;
        CreditPanel.SetActive(false);
    }

}
