using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkullGame : MonoBehaviour
{
    public static bool SkullClear = false;

    private void Update()
    {
        if (SkullClear)
        {
            bool checkInven = this.gameObject.GetComponent<InventoryAdd>().CheckInventory((int)Items.COIN);

            if (!checkInven)
                Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.COIN;
        }
    }

    public void ButtonClicked()
    {
        Map.PlayerPlace = (int)Places.SKULL_SWAMP;
        SceneManager.LoadScene("SkullSwampScene");
    }

    public void AgainBtnClicked()
    {
        SceneManager.LoadScene("SkullGameScene");
    }

}
