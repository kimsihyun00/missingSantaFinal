using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllContract : MonoBehaviour
{
    public GameObject ContractPopUp;
    public GameObject UnlockedContract;
    bool allContracts = true;
    bool contractsChecked = false;
    public void contractPopUpCloseBtnClicked()
    {
        ContractPopUp.SetActive(false);
    }

    public void contractPopUpBtnClicked()
    {
        UnlockedContract.SetActive(true);
    }

    public void unlockedContractCloseBtnClicked()
    {
        UnlockedContract.SetActive(false);
    }

    public void checkContracts()
    {
        bool[] haveContract = new bool[14];

        for (int i = 0; i < 14; i++)
            haveContract[i] = false;

        for (int i = 0; i < Inventory.InventoryItems.Length; i++)
        {
            for (int contractNum = (int)Items.CONTRACT1; contractNum <= (int)Items.CONTRACT5; contractNum++)
            {
                if (Inventory.InventoryItems[i] == contractNum)
                    haveContract[contractNum] = true;
            }
        }

        for (int contractNum = (int)Items.CONTRACT1; contractNum <= (int)Items.CONTRACT5; contractNum++)
        {
            if (!haveContract[contractNum])
                allContracts = false;
        }

        if (allContracts)
        {
            contractsChecked = true;
        }
        else
        {
            contractsChecked = false;           
        }
    }

    private void Update()
    {
        if (!DialogManager.Talking && allContracts && contractsChecked)
        {
            ContractPopUp.SetActive(true);
        }
    }

}
