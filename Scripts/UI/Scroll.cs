using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    public GameObject ScrollBar;

    public void Example1Clicked()
    {
        ScrollBar.GetComponent<Scrollbar>().value = 0.8f;
    }

    public void Example2Clicked()
    {
        ScrollBar.GetComponent<Scrollbar>().value = 0.6f;
    }

    public void Example3Clicked()
    {
        ScrollBar.GetComponent<Scrollbar>().value = 0.4f;
    }

    public void Example4Clicked()
    {
        ScrollBar.GetComponent<Scrollbar>().value = 0.2f;
    }

    public void Example5Clicked()
    {
        ScrollBar.GetComponent<Scrollbar>().value = 0f;
    }

}
