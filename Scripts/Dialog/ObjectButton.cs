using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectButton : MonoBehaviour
{
    public ObjectLines Dialog;

    public GameObject DialogPanel;

    private void OnEnable()
    {
        Dialog = this.gameObject.GetComponent<ObjectLines>();
    }

    public void ObjectBtnClicked()
    {
        Debug.Log("Clicked");
        if (!DialogManager.Talking)
        {
            Debug.Log("NotTalking");
            DialogManager.Talking = true;
            DialogPanel.GetComponent<DialogManager>().StartDialog(Dialog);
        }
    }
}
