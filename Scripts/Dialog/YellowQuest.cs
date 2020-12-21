using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowQuest : MonoBehaviour
{
    public GameObject YellowBefore;
    public GameObject YellowAfter;

    public GameObject PopUpPanel;
    public Button PopUpBtn;
    public Text PopUpPanelText;
    public Text PopUpBtnText;

    public ObjectLines Dialog;
    public GameObject DialogPanel;

    int index = -1;
    public static bool YellowClicked = false;

    private void Start()
    {
        if (YellowClicked)
            YellowBefore.SetActive(false);

        PopUpBtnText.text = "노랑이에게 햄버거 주기";
        Dialog = this.gameObject.GetComponent<ObjectLines>();
    }

    public void YellowBeforeBtnClicked()
    {
        if (AnswerNote.Chapter >= 3)
        {
            YellowClicked = true;
            YellowBefore.SetActive(false);
            YellowAfter.SetActive(true);
        }
    }

    public void YellowAfterBtnClicked()
    {   
        if (!DialogManager.Talking)
        {
            PopUpPanel.SetActive(true);

            for (int i = 0; i < Inventory.InventoryItems.Length; i++)
            {
                if (Inventory.InventoryItems[i] == (int)Items.HAMBURGER)
                    index = i;
            }

            if (index != -1)
            {
                PopUpPanelText.text = "가방안에 햄버거가 있습니다.\n\n마녀의 계약서 한 조각을 얻기 위해\n\n노랑이에게 햄버거를 주시겠습니까?";
                PopUpBtn.interactable = true;
            }
            else
            {
                PopUpPanelText.text = "가방안에 햄버거가 없습니다!\n\n노랑이에게 햄버거를 주기 위해서는\n\n키오스크에서 햄버거를 구매해야 합니다.";
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

        for(int i=index; i<Inventory.ItemNums; i++)
        {
            Inventory.InventoryItems[i] = Inventory.InventoryItems[i + 1];
        }

        Inventory.InventoryItems[Inventory.ItemNums--] = -1;

        StartCoroutine(GetContract5());
    }

    public void PopUpCloseClicked()
    {
        PopUpPanel.SetActive(false);
    }

    IEnumerator GetContract5()
    {
        yield return new WaitForSeconds(0.5f);

        bool checkInven = this.gameObject.GetComponent<InventoryAdd>().CheckInventory((int)Items.CONTRACT5);

        if (!checkInven)
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.CONTRACT5;

        GameObject.Find("ContractPopUp").GetComponent<AllContract>().checkContracts();
    }
}
