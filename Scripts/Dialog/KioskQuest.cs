using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KioskQuest : MonoBehaviour
{
    public GameObject PopUpPanel;
    public Button PopUpBtn;
    public Text PopUpPanelText;
    public Text PopUpBtnText;

    int index = -1;

    private void Start()
    {
        PopUpBtnText.text = "햄버거 구매하기";
    }

    public void KioskBtnClicked()
    {
        if (!DialogManager.Talking)
        {
            PopUpPanel.SetActive(true);

            for (int i = 0; i < Inventory.InventoryItems.Length; i++)
            {
                if (Inventory.InventoryItems[i] == (int)Items.COIN)
                    index = i;
            }

            if (index != -1)
            {
                PopUpPanelText.text = "가방 안에 이 마을에서 사용가능한\n\n동전이 있습니다. 햄버거를 주문하기\n\n위해 사용하시겠습니까? (소요 시간 2초)";
                PopUpBtn.interactable = true;
            }
            else
            {
                PopUpPanelText.text = "햄버거를 주문하기 위해서는 이 마을에서 \n\n사용하는 동전을 필요로 합니다.\n\n동전을 구해오셔야 구매가 가능합니다.";
                PopUpBtn.interactable = false;
            }
        }
    }

    public void PopUpBtnClicked()
    {
        PopUpPanel.SetActive(false);

        for (int i = index; i < Inventory.ItemNums; i++)
        {
            Inventory.InventoryItems[i] = Inventory.InventoryItems[i + 1];
        }

        Inventory.InventoryItems[Inventory.ItemNums--] = -1;
    }

    public void PopUpCloseClicked()
    {
        PopUpPanel.SetActive(false);
    }

}
