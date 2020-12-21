using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SledGame : MonoBehaviour
{
    public static bool SledClear = false;

    public ObjectLines Dialog;
    public GameObject DialogPanel;

    bool dialogPlayed = false;

    private void Start()
    {
        Dialog = this.gameObject.GetComponent<ObjectLines>();
    }

    private void Update()
    {
        if(SledClear && !dialogPlayed)
        {
            if (!DialogManager.Talking)
            {
                DialogManager.Talking = true;
                DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog);
            }
            dialogPlayed = true;
        }
    }

    public void ButtonClicked()
    {
        Map.PlayerPlace = (int)Places.RUDOLPH_FOREST;
        SceneManager.LoadScene("RudolphForestScene");
    }

    public void AgainBtnClicked()
    {
        SceneManager.LoadScene("SledGameScene");
    }
}
