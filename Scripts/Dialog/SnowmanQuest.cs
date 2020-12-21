using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnowmanQuest : MonoBehaviour
{
    public GameObject Snowman;

    public GameObject PopUpPanel;
    public Button PopUpBtn;
    public Text PopUpPanelText;
    public Text PopUpBtnText;

    public ObjectLines Dialog;
    public GameObject DialogPanel;

    public static bool SnowmanClicked = false;
    int index = -1;

    private void Start()
    {
        PopUpBtnText.text = "생명력 물약 주기";
    }

    public void SnowmanBeforeBtnClicked()
    {
        if (!DialogManager.Talking && AnswerNote.Chapter >=3)
        {
            PopUpPanel.SetActive(true);

            for (int i = 0; i < Inventory.InventoryItems.Length; i++)
            {
                if (Inventory.InventoryItems[i] == (int)Items.POTION)
                    index = i;
            }

            if (index != -1)
            {
                PopUpPanelText.text = "가방 안에 마녀에게서 얻은 생명력 \n\n물약이 있습니다. 눈사람에게 생명을\n\n주기 위해 사용하시겠습니까 ?";
                PopUpBtn.interactable = true;
            }
            else
            {
                PopUpPanelText.text = "가방 안에 생명력 물약이 없습니다. \n\n눈사람에게 생명을 주기 위해서는\n\n생명력 물약이 필요합니다. (힌트: 마녀)";
                PopUpBtn.interactable = false;
            }
        }
    }

    public void PopUpBtnClicked()
    {
        PopUpPanel.SetActive(false);

        if (!DialogManager.Talking)
        {
            DialogManager.Talking = true;
            DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog);
        }

        for (int i = index; i < Inventory.ItemNums; i++)
        {
            Inventory.InventoryItems[i] = Inventory.InventoryItems[i + 1];
        }

        Inventory.InventoryItems[Inventory.ItemNums--] = -1;

        StartCoroutine(GetContract1());
    }

    public void PopUpCloseClicked()
    {
        PopUpPanel.SetActive(false);
    }

    IEnumerator GetContract1()
    {
        yield return new WaitForSeconds(0.5f);

        bool checkInven = this.gameObject.GetComponent<InventoryAdd>().CheckInventory((int)Items.CONTRACT1);

        if (!checkInven)
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.CONTRACT1;

        GameObject.Find("ContractPopUp").GetComponent<AllContract>().checkContracts();
    }

}
