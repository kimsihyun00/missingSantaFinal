using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

enum Places
{
    SKULL_SWAMP,
    WITCH_HOUSE,
    FASTFOOD,
    DAYCARE,
    PLAYGROUND,
    SANTA_HOUSE,
    RUDOLPH_FOREST
}

public class Map : MonoBehaviour
{
    public static int PlayerPlace = (int)Places.SANTA_HOUSE;

    public GameObject MainCanvas;

    public void SkullSwampBtnClicked()
    {
        MainButton.BtnNum = -1;
        SceneManager.LoadScene("SkullSwampScene");

        Map.PlayerPlace = (int)Places.SKULL_SWAMP;
    }

    public void WitchHouseBtnClicked()
    {
        MainButton.BtnNum = -1;
        SceneManager.LoadScene("WitchHouseOutScene");

        Map.PlayerPlace = (int)Places.WITCH_HOUSE;
    }

    public void FastFoodBtnClicked()
    {
        MainButton.BtnNum = -1;
        SceneManager.LoadScene("FastFoodScene");

        Map.PlayerPlace = (int)Places.FASTFOOD;
    }

    public void DaycareBtnClicked()
    {
        MainButton.BtnNum = -1;
        SceneManager.LoadScene("DaycareOutScene");

        Map.PlayerPlace = (int)Places.DAYCARE;
    }

    public void PlaygroundBtnClicked()
    {
        MainButton.BtnNum = -1;
        SceneManager.LoadScene("PlaygroundScene");

        Map.PlayerPlace = (int)Places.PLAYGROUND;
    }

    public void SantaHouseBtnClicked()
    {
        MainButton.BtnNum = -1;
        SceneManager.LoadScene("SantaHouseOutScene");

        Map.PlayerPlace = (int)Places.SANTA_HOUSE;
    }

    public void RudolphForestBtnClicked()
    {
        MainButton.BtnNum = -1;
        SceneManager.LoadScene("RudolphForestScene");

        Map.PlayerPlace = (int)Places.RUDOLPH_FOREST;
    }

    public void  GoInsideBtnClicked()
    {
        switch(Map.PlayerPlace)
        {
            case (int)Places.WITCH_HOUSE:
                SceneManager.LoadScene("WitchHouseInScene");
                break;
            case (int)Places.SANTA_HOUSE:
                SceneManager.LoadScene("SantaHouseInScene");
                break;
            case (int)Places.DAYCARE:
                SceneManager.LoadScene("DaycareInScene");
                break;
        }
    }
}
