using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAdd : MonoBehaviour
{
    public void BranchBtnClicked()
    {
        if (!CheckInventory((int)Items.BRANCHS))
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.BRANCHS;
    }

    public void OldBookBtnClicked()
    {
        if (!CheckInventory((int)Items.OLD_BOOK))
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.OLD_BOOK;
    }

    public void KioskBtnClicked()
    {
        if (!CheckInventory((int)Items.HAMBURGER) && AnswerNote.Chapter >= 3)
            StartCoroutine(GetHamBurger());
    }

    public void SocksContractBtnClicked()
    {
        if (!CheckInventory((int)Items.CONTRACT4) && AnswerNote.Chapter >= 3)
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.CONTRACT4;

        GameObject.Find("ContractPopUp").GetComponent<AllContract>().checkContracts();
    }

    public void GreenContractBtnClicked()
    {
        if (!CheckInventory((int)Items.CONTRACT3) && AnswerNote.Chapter >= 3)
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.CONTRACT3;

        GameObject.Find("ContractPopUp").GetComponent<AllContract>().checkContracts();
    }

    public void BoardContractBtnClicked()
    {
        if (!CheckInventory((int)Items.CONTRACT2) && AnswerNote.Chapter >= 3)
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.CONTRACT2;

        GameObject.Find("ContractPopUp").GetComponent<AllContract>().checkContracts();
    }

    public void ButtonsBtnClicked()
    {
        if (!CheckInventory((int)Items.BUTTONS))
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.BUTTONS;
    }

    public void WitchClearBtnClicked()
    {
        if (!CheckInventory((int)Items.POTION) && AnswerNote.Chapter >= 3)
            StartCoroutine(GetPotion());
    }

    public void TowelBtnClicked()
    {
        if (!CheckInventory((int)Items.TOWEL))
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.TOWEL;
    }

    public void SocksKeyBtnClicked()
    {
        if (!CheckInventory((int)Items.KEY))
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.KEY;
    }

    public void CarrotBtnClicked()
    {
        if (!CheckInventory((int)Items.CARROT))
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.CARROT;
    }

    public void SkullClearBtnClicked()
    {
        if (!CheckInventory((int)Items.COIN))
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.COIN;
    }


    public bool CheckInventory(int itemNum)
    {
        bool HaveItem = false;
        for(int i=0; i<Inventory.InventoryItems.Length; i++)
        {
            if (Inventory.InventoryItems[i] == itemNum)
                HaveItem = true;
        }
        return HaveItem;
    }

    IEnumerator GetHamBurger()
    {
        yield return new WaitForSeconds(2f);
        Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.HAMBURGER;
    }

    IEnumerator GetPotion()
    {
        yield return new WaitForSeconds(0.5f);
        Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.POTION;
    }
}