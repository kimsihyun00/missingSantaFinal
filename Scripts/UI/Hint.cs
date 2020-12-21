using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    // Hint Panel Handle
    public Text HintText;

    string[] ChapterHints =
    {
        "산타의 일기와 고서를 통해 아이들의 존재와\n이 마을의 정체에 대해 추측하세요!",
        "아이들의 대화를 통해 사인을 추측하세요.\n아이들은 죽음에 개념에 대해 잘 모르니 혼자서만 알고 계세요!",
        "산타가 어디로 떠났을지 알기 위해 찢어진 마녀의 계약서를 찾아보세요.\n계약서에 장소가 적혀있을지도 몰라요!"
    };

    public void HintBtnClicked()
    {
        HintText.text = ChapterHints[AnswerNote.Chapter - 1];
    }
}
