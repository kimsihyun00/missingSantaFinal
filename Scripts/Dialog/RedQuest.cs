using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RedQuest : MonoBehaviour
{
    public GameObject RedBefore;
    public GameObject RedAfter;

    public GameObject SnowManObj;
    public GameObject bgAfter;

    public GameObject PopUpPanel;
    public Button PopUpBtn;
    public Text PopUpPanelText;
    public Text PopUpBtnText;

    int[] index = { -1, -1, -1, -1 };
    int[] indexCheck = { 0, 0, 0, 0 };
    public static bool RedClicked = false;

    private void Start()
    {
        if (!SnowManGame.SnowManClear)
        {
            SnowManObj.SetActive(false);
        }
        else
        {
            SnowManObj.SetActive(true);
            bgAfter.SetActive(true);
        }

        if (RedClicked)
            RedBefore.SetActive(false);

        PopUpBtnText.text = "눈사람 만들기";
    }

    public void RedBeforeBtnClicked()
    {
        RedClicked = true;
        RedBefore.SetActive(false);
        RedAfter.SetActive(true);
    }

    public void RedAfterBtnClicked()
    {
        bool allMaterials = true;

        if (!DialogManager.Talking)
        {
            PopUpPanel.SetActive(true);

            for (int i = 0; i < Inventory.InventoryItems.Length; i++)
            {
                if (Inventory.InventoryItems[i] == (int)Items.BUTTONS)
                {
                    indexCheck[0] = 1;
                    index[0] = i;
                }
                if (Inventory.InventoryItems[i] == (int)Items.TOWEL)
                {
                    indexCheck[1] = 1;
                    index[1] = i;
                }
                if (Inventory.InventoryItems[i] == (int)Items.CARROT)
                {
                    indexCheck[2] = 1;
                    index[2] = i;
                }
                if (Inventory.InventoryItems[i] == (int)Items.BRANCHS)
                {
                    indexCheck[3] = 1;
                    index[3] = i;
                }
            }

            for (int i = 0; i < indexCheck.Length; i++)
            {
                if (indexCheck[i] != 1)
                    allMaterials = false;
            }

            if (allMaterials)
            {
                PopUpPanelText.text = "가방 안에 눈사람을 만들 재료가 모두 \n\n모였습니다.단추, 당근, 타올, 나뭇가지로\n\n눈사람 만들기에 도전하시겠습니까?";
                PopUpBtn.interactable = true;
            }
            else
            {
                PopUpPanelText.text = "가방 안에 눈사람의 눈코입 재료가 \n\n부족합니다.재료를 더 구해와서\n\n도전해보세요!(단추, 당근, 나뭇가지, 타올)";
                PopUpBtn.interactable = false;
            }
        }

    }

    public void PopUpBtnClicked()
    {
        for (int i = 0; i < 4; i++)
            deleteItem(index[i]);
        SceneManager.LoadScene("SnowManGameScene");
    }

    public void PopUpCloseClicked()
    {
        PopUpPanel.SetActive(false);
    }

    void deleteItem(int index)
    {
        if (index != 9)
            for (int i = index; i < Inventory.ItemNums; i++)
            {
                Inventory.InventoryItems[i] = Inventory.InventoryItems[i + 1];
            }

        Inventory.InventoryItems[Inventory.ItemNums--] = -1;
    }
}
