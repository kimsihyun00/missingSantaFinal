using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenPopUp : MonoBehaviour
{
    public GameObject InventoryInPanel;

    bool PopUpMsgNeeded = false;
    int CurrentNum;

    private void Start()
    {
        CurrentNum = Inventory.ItemNums;
    }

    public void Update()
    {

        if (CurrentNum < Inventory.ItemNums)
        {
            PopUpMsgNeeded = true;
        }

        CurrentNum = Inventory.ItemNums;

        if (!DialogManager.Talking && PopUpMsgNeeded)
        {
            InventoryInPanel.SetActive(true);
            PopUpMsgNeeded = false;
        }

    }

    public void CloseBtnClicked()
    {
        InventoryInPanel.SetActive(false);
    }
}
