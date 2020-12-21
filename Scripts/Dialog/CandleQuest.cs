using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleQuest : MonoBehaviour
{
    public GameObject CandleOn1;
    public GameObject CandleOff1;

    public GameObject CandleOn2;
    public GameObject CandleOff2;

    public GameObject CandleOn3;
    public GameObject CandleOff3;

    public GameObject CandleOn4;
    public GameObject CandleOff4;

    public static bool CandleClicked1 = false;
    public static bool CandleClicked2 = false;
    public static bool CandleClicked3 = false;
    public static bool CandleClicked4 = false;

    private void Start()
    {
        if (CandleClicked1)
            CandleOn1.SetActive(false);

        if (CandleClicked2)
            CandleOn2.SetActive(false);

        if (CandleClicked3)
            CandleOn3.SetActive(false);

        if (CandleClicked4)
            CandleOn3.SetActive(false);
    }

    public void Candle1BtnClicked()
    {
        if (AnswerNote.Chapter >= 2)
        {
            CandleClicked1 = true;
            CandleOn1.SetActive(false);
            CandleOff1.SetActive(true);
        }
    }

    public void Candle2BtnClicked()
    {
        if (AnswerNote.Chapter >= 2)
        {
            CandleClicked2 = true;
            CandleOn2.SetActive(false);
            CandleOff2.SetActive(true);
        }
    }
    public void Candle3BtnClicked()
    {
        if (AnswerNote.Chapter >= 2)
        {
            CandleClicked3 = true;
            CandleOn3.SetActive(false);
            CandleOff3.SetActive(true);
        }
    }
    public void Candle4BtnClicked()
    {
        if (AnswerNote.Chapter >= 2)
        {
            CandleClicked4 = true;
            CandleOn4.SetActive(false);
            CandleOff4.SetActive(true);
        }
    }
}
