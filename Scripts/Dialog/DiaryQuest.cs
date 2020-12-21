using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaryQuest : MonoBehaviour
{
    public GameObject Pillow;
    public GameObject Diary;

    public GameObject DiaryPopUpPanel;
    public Button DiaryPopUpBtn;
    public Text DiaryPopUpPanelText;
    public Text DiaryPopUpBtnText;

    public GameObject UnlockedDiary;
    public Text DateText;
    public Text ContentText;
    public GameObject UnlockedLeftBtn;
    public GameObject UnlockedRightBtn;

    public ObjectLines Dialog;
    public GameObject DialogPanel;

    int index = -1;
    public static bool PillowClicked = false;
    public static bool Unlocked = false;

    int diaryIndex = 0;

    string[] Dates =
    { 
        "10월 31일,",
        "11월 3일,",
        "11월 10일,",
        "11월 15일,",
        "11월 22일,",
        "12월 1일,",
        "12월 11일,",
        "12월 19일,",
        "12월 23일,"
    };

    string[] Contents =
    {
        "다시 할로윈이다. 아이들이 귀엽고 사랑스럽지만, 가끔은 무서워진다.",
        "이번 겨울은 몇 번째 겨울인걸까? 난 모르겠다. 겨울 뿐인 세상에서 겨울을 세는 의미는 없겠지.",
        "마녀를 만났다. 마녀는 나와는 생각이 다른 것 같다. 나도 물론 아이들과 헤어지기는 싫다.",
        "기억이 조금씩 돌아오고 있다. 내 삶에서의 가족들이 그립다.",
        "아이들은 가끔씩 무언가를 무서워한다. 아마도 그건 아이들이 이곳에 온 이유와 관련있겠지.",
        "이번 크리스마스 전에 떠나려고 한다. 이 아이들을 어떻게 두고 가지?",
        "아이들을 좋은 분께 부탁했다. 내가 떠나도 슬퍼하지는 않았으면 좋겠다...",
        "아이들이 그리울 것이다. 하지만 몇년째 봄이 오지 않은 채 사는 것이 괴로워 견딜 수가 없다.",
        "나는 내일 떠난다. 파랑, 남이, 보라, 분홍아... 미안해..."
    };


    private void Start()
    {
        if (PillowClicked)
            Pillow.SetActive(false);

        Dialog = this.gameObject.GetComponent<ObjectLines>();
    }

    public void PillowBtnClicked()
    {
        PillowClicked = true;
        Pillow.SetActive(false);
        Diary.SetActive(true);
    }

    public void DiaryBtnClicked()
    {
        if (!DialogManager.Talking)
        {
            DiaryPopUpPanel.SetActive(true);

            for (int i = 0; i < Inventory.InventoryItems.Length; i++)
            {
                if (Inventory.InventoryItems[i] == (int)Items.KEY)
                    index = i;
            }

            if (index != -1)
            {
                DiaryPopUpPanelText.text = "가방 안에 열쇠가 있습니다. 산타의 일기\n\n장에 꼭 맞는 열쇠입니다. 일기장을 읽기\n\n위해 여시겠습니까?";
                DiaryPopUpBtn.interactable = true;
            }
            else
            {
                DiaryPopUpPanelText.text = "가방 안에 열쇠가 없습니다. 산타의 일기\n\n장을 열기 위해서는 일기장에 꼭 맞는\n\n열쇠가 필요합니다.";
                DiaryPopUpBtn.interactable = false;
            }
        }
    }

    public void PopUpBtnClicked()
    {
        UnlockedDiary.SetActive(true);

        /*
        for (int i = index; i < Inventory.ItemNums; i++)
        {
            Inventory.InventoryItems[i] = Inventory.InventoryItems[i + 1];
        }

        Inventory.InventoryItems[Inventory.ItemNums--] = -1;
        */
    }

    public void LeftBtnClicked()
    {
        diaryIndex--;

        if (diaryIndex == 0)
        {
            UnlockedLeftBtn.SetActive(false);
            UnlockedRightBtn.SetActive(true);
        }
        else
        {
            UnlockedLeftBtn.SetActive(true);
            UnlockedRightBtn.SetActive(true);
        }

        DateText.text = Dates[diaryIndex];
        ContentText.text = Contents[diaryIndex];
    }

    public void RightBtnClicked()
    {
        diaryIndex++;

        if(diaryIndex==Dates.Length-1)
        {
            UnlockedLeftBtn.SetActive(true);
            UnlockedRightBtn.SetActive(false);
        }
        else
        {
            UnlockedLeftBtn.SetActive(true);
            UnlockedRightBtn.SetActive(true);
        }

        DateText.text = Dates[diaryIndex];
        ContentText.text = Contents[diaryIndex];
    }

    public void PopUpCloseClicked()
    {
        DiaryPopUpPanel.SetActive(false);
    }

    public void UnLockDiaryCloseClicked()
    {
        UnlockedDiary.SetActive(false);
    }
}
