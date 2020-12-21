using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chapter2 : MonoBehaviour
{
    public ObjectLines Dialog;
    public GameObject DialogPanel;

    void Start()
    {
        Debug.Log(AnswerNote.Chapter);

        StartCoroutine(Chapter2Dialog());
    }

    IEnumerator Chapter2Dialog()
    {
        yield return new WaitForSeconds(0.1f);

        if (!DialogManager.Talking)
        {
            DialogManager.Talking = true;
            DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog);
        }
    }

    public void Chapter2EndBtnClicked()
    {
        Map.PlayerPlace = (int)Places.SANTA_HOUSE;
        SceneManager.LoadScene("SantaHouseOutScene");
    }
}
