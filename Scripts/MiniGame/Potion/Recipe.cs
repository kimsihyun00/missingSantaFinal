using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipe : MonoBehaviour
{
    public GameObject[] recipePanels = new GameObject[4];
    public GameObject recipePanel;
    public GameObject[] potionBtns = new GameObject[8];

    public GameObject RecipeClearPanel;
    public GameObject clearImage;
    public Sprite[] clearSprites = new Sprite[4];
    public Text clearText;
    public Text NextBtnText;

    string[] RecipeTextStr =
    {
        "믿음의 묘약 완성!\n다음 묘약도 만들어보세요.",
        "소망의 묘약 완성!\n다음 묘약도 만들어보세요.",
        "사랑의 묘약 완성!\n다음 묘약도 만들어보세요.",
        "생명의 묘약 완성!\n모든 묘약을 완성했습니다."
    };

    public GameObject ClearBtn;
    public GameObject GameOverPanel;

    public GameObject RecipeBtn;
    public GameObject MakeBtn;

    int recipeNum = 0;

    private int[] trustRecipe = { 2, 4, 5, 6 };
    private int[] wishRecipe = { 1, 2, 3, 5 };
    private int[] loveRecipe = { 0, 1, 2, 7 };
    private int[] lifeRecipe = { 0, 1, 2, 3, 4, 5, 6, 7 };

    private Queue<int> playerRecipe = new Queue<int>();
    int color = -1;

    public void RedBtnClicked()
    {
        color = 0;
        ColorAddToQueue(color);
    }

    public void OrangeBtnClicked()
    {
        color = 1;
        ColorAddToQueue(color);
    }

    public void YellowBtnClicked()
    {
        color = 2;
        ColorAddToQueue(color);
    }

    public void GreenBtnClicked()
    {
        color = 3;
        ColorAddToQueue(color);
    }

    public void BlueBtnClicked()
    {
        color = 4;
        ColorAddToQueue(color);
    }

    public void NavyBtnClicked()
    {
        color = 5;
        ColorAddToQueue(color);
    }

    public void PuppleBtnClicked()
    {
        color = 6;
        ColorAddToQueue(color);
    }

    public void PinkBtnClicked()
    {
        color = 7;
        ColorAddToQueue(color);
    }

    public void RecipeBtnClicked()
    {
        recipePanel.SetActive(true);
        recipePanels[recipeNum].SetActive(true);
    }

    public void RecipeCloseBtnClicked()
    {
        recipePanels[recipeNum].SetActive(false);
        recipePanel.SetActive(false);
    }

    public void MakeBtnClicked()
    {
        if(CheckRecipe(recipeNum))
        {
            RecipeClearPanel.SetActive(true);
            clearImage.GetComponent<Image>().sprite = clearSprites[recipeNum];
            clearText.text = RecipeTextStr[recipeNum];
            recipeNum++;
            if (recipeNum >= 4)
                NextBtnText.text = "묘약 완성!";
        }
        else
        {
            GameOverPanel.SetActive(true);
        }
        playerRecipe.Clear();
    }

    public void NextBtnClicked()
    {
        RecipeClearPanel.SetActive(false);
        if (recipeNum >= 4)
        {
            PotionGame.PotionClear = true;
            ClearBtn.SetActive(true);
            RecipeBtn.SetActive(false);
            MakeBtn.SetActive(false);
            
        }
        else
            for (int i = 0; i < potionBtns.Length; i++)
                potionBtns[i].SetActive(true);
    }


    void ColorAddToQueue(int colorClicked)
    {
        potionBtns[color].SetActive(false);
        playerRecipe.Enqueue(colorClicked);
    }

    
    bool CheckRecipe(int recipeNum)
    {
        bool result = true;

        switch (recipeNum)
        {
            case 0:
                if (playerRecipe.Count != 4)
                    result = false;
                for (int i = 0; i < playerRecipe.Count; i++)
                {
                    if (playerRecipe.Dequeue() != trustRecipe[i])
                        result = false;
                }
                break;
            case 1:
                if (playerRecipe.Count != 4)
                    result = false;
                for (int i = 0; i < playerRecipe.Count; i++)
                {
                    if (playerRecipe.Dequeue() != wishRecipe[i])
                        result = false;
                }
                break;
            case 2:
                if (playerRecipe.Count != 4)
                    result = false;
                for (int i = 0; i < playerRecipe.Count; i++)
                {
                    if (playerRecipe.Dequeue() != loveRecipe[i])
                        result = false;
                }
                break;
            case 3:
                if (playerRecipe.Count != 8)
                    result = false;
                for (int i = 0; i < playerRecipe.Count; i++)
                {
                    if (playerRecipe.Dequeue() != lifeRecipe[i])
                        result = false;
                }
                break;
        }


        return result;
    }
}
