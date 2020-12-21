using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class SnowManGame : MonoBehaviour
{
    public static bool SnowManClear = false;

    public GameObject ClearBtn;

    public GameObject GoBackBtn;

    public ObjectLines Dialog;
    public GameObject DialogPanel;

    bool dialogPlayed = false;

    private int clearNum = 8;
    private int currentCount = 0;

    private void Start()
    {
        clearNum = 8;
        currentCount = 0;
        Dialog = this.gameObject.GetComponent<ObjectLines>();
    }

    public void ButtonClicked()
    {
        Map.PlayerPlace = (int)Places.PLAYGROUND;

        SceneManager.LoadScene("PlaygroundScene");
    }

    private void Update()
    {
        if(currentCount == clearNum)
        {
            ClearBtn.SetActive(true);
            GoBackBtn.SetActive(false);

            if (!dialogPlayed)
            {
                SnowManClear = true;

                if (!DialogManager.Talking)
                {
                    DialogManager.Talking = true;
                    DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog);
                }
                dialogPlayed = true;
            }
        }
    }
    public void AddClears()
    {
        currentCount++;
    }
}