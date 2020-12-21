using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RudolphQuest : MonoBehaviour
{
    public GameObject RudolphBefore;
    public GameObject RudolphAfter;

    public GameObject RudolphPopUpPanel;

    public GameObject DialogPanel;

    public GameObject OldBookPopUpPanel;
    public Text OldBookPopUpPanelText;
    public Button OldBookPopUpBtn;

    public static bool RudolphClicked = false;

    bool OldBookOpen = false;
    bool OldBookPopUp = false;

    private void Start()
    {
        if (RudolphClicked)
            RudolphBefore.SetActive(false);
    }

    private void Update()
    {
        if (OldBookOpen && !DialogManager.Talking && !OldBookPopUp)
        {
            OldBookPopUp = true;
            OldBookPopUpPanel.SetActive(true);
            
            int index = -1;
            
            for (int i = 0; i < Inventory.InventoryItems.Length; i++)
            {
                if (Inventory.InventoryItems[i] == (int)Items.OLD_BOOK)
                    index = i;
            }

            if (index != -1)
            {
                OldBookPopUpPanelText.text = "루돌프가 썰매 타는 것의 대가로 고서를\n\n해석해줬습니다.이곳에 오면 고서를\n\n언제든 읽을 수 있습니다.";
                OldBookPopUpBtn.interactable = true;
            }
            else
            {
                OldBookPopUpPanelText.text = "루돌프가 썰매를 함께 타준 것에 감사\n\n하고 있습니다. 알맞은 물건을 가져오면\n\n루돌프가 도움이 될 겁니다.(힌트: 고서)";
                OldBookPopUpBtn.interactable = false;
            }

        }
    }

    public void RudolphBeforeBtnClicked()
    {
        RudolphClicked = true;
        RudolphBefore.SetActive(false);
        RudolphAfter.SetActive(true);
    }

    public void RudolphAfterBtnClicked()
    {
        if (!DialogManager.Talking)
        {
            if (!SledGame.SledClear)
                RudolphPopUpPanel.SetActive(true);
            else
            {
                OldBookOpen = true;
                OldBookPopUp = false;
            }
        }
    }

    public void PopUpBtnClicked()
    {
        SceneManager.LoadScene("SledGameScene");
    }

    public void RudolphPopUpCloseClicked()
    {
        RudolphPopUpPanel.SetActive(false);
    }
}
