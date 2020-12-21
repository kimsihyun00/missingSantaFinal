using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chapter3 : MonoBehaviour
{
    public ObjectLines Dialog;
    public GameObject DialogPanel;

    void Start()
    {
        Debug.Log(AnswerNote.Chapter);
        StartCoroutine(Chapter3Dialog());
    }

    IEnumerator Chapter3Dialog()
    {
        yield return new WaitForSeconds(0.1f);

        if (!DialogManager.Talking)
        {
            DialogManager.Talking = true;
            DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog);
        }
    }

    public void Chapter3EndBtnClicked()
    {
        SceneManager.LoadScene("EndingScene");
    }

}
