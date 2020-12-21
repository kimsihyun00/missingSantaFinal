using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OldBookQuest : MonoBehaviour
{
    public GameObject OldBookPopUpPanel;
    public GameObject UnlockedOldBook;

    public GameObject UnlockedLeftBtn;
    public GameObject UnlockedRightBtn;

    public Text TitleText;
    public Text ContentText;

    string[] Titles = { "숨겨진 마을", "그곳의 아이들", "어른들" };
    string[] Contents =
    {
        "그 마을은 숨겨진 차원 속에 있다. 아이들의 영원한 행복을 바라는 누군가의 간절하고도 애달픈 염원들이 모여서 이 마을이 생겨났다. 누군가는 이 마을을 무지개마을이라고 부른다.",
        "아이들은 영원히 살 수 있지만, 영원히 아이의 모습이어야만 하는 슬픈 사정을 가진 영혼들이다. 그들이 세상을 떠나 이곳에 온 이유는 각각 다르지만, 아이들은 모두 기억을 잃어 이곳이 어디인지조차 모른다. 아이들의 기억을 거둔 것은 아이들의 행복 때문일 것이다." ,
        "어른들은 영원을 살 수 없고 마을에 속하지 않은 자들이다. 그들은 계약을 통해 이 마을에 엮여 있을 뿐이고 심장이 뛰는 수명이 남은 사람들이다. 그러나 계약서를 찢으면 이 마을에 속해 영원히 살 수 있으며, 계약서를 찢는 순간 영원한 행복 속에 갇힌 존재가 된다."
    };
    int oldBookIndex = 0;

    public void OldBookPopUpBtnClicked()
    {
        UnlockedOldBook.SetActive(true);
        TitleText.text = Titles[oldBookIndex];
        ContentText.text = Contents[oldBookIndex];
    }

    public void LeftBtnClicked()
    {
        oldBookIndex--;

        if (oldBookIndex == 0)
        {
            UnlockedLeftBtn.SetActive(false);
            UnlockedRightBtn.SetActive(true);
        }
        else
        {
            UnlockedLeftBtn.SetActive(true);
            UnlockedRightBtn.SetActive(true);
        }

        TitleText.text = Titles[oldBookIndex];
        ContentText.text = Contents[oldBookIndex];
    }

    public void RightBtnClicked()
    {
        oldBookIndex++;

        if (oldBookIndex == Titles.Length - 1)
        {
            UnlockedLeftBtn.SetActive(true);
            UnlockedRightBtn.SetActive(false);
        }
        else
        {
            UnlockedLeftBtn.SetActive(true);
            UnlockedRightBtn.SetActive(true);
        }

        TitleText.text = Titles[oldBookIndex];
        ContentText.text = Contents[oldBookIndex];
    }


    public void UnlockedOldBookCloseBtnClicked()
    {
        UnlockedOldBook.SetActive(false);
    }

    public void OldBookPopUpCloseClicked()
    {
        OldBookPopUpPanel.SetActive(false);
    }
}
