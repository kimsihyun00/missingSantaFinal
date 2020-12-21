using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasQuest : MonoBehaviour
{
    public GameObject GasOn;
    public GameObject GasOff;

    public GameObject GasOn2;
    public GameObject GasOff2;

    public static bool GasClicked = false;
    public static bool GasClicked2 = false;

    private void Start()
    {
        if (GasClicked)
            GasOn.SetActive(false);

        if (GasClicked2)
            GasOn2.SetActive(false);
    }

    public void GasBtnClicked()
    {
        if (AnswerNote.Chapter >= 2)
        {
            GasClicked = true;
            GasOn.SetActive(false);
            GasOff.SetActive(true);
        }
    }

    public void Gas2BtnClicked()
    {
        if (AnswerNote.Chapter >= 2)
        {
            GasClicked2 = true;
            GasOn2.SetActive(false);
            GasOff2.SetActive(true);
        }
    }
}