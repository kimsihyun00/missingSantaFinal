using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintCircle : MonoBehaviour
{
    public int chapterOpen;

    public Sprite Circle;
    public Sprite None;

    private void Start()
    {
        if (AnswerNote.Chapter == chapterOpen)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Circle;
            StartCoroutine(Blink());
        }
        else
            this.gameObject.GetComponent<SpriteRenderer>().sprite = None;

    }

    IEnumerator Blink()
    {
        for (int i = 0; i < 1000; i++)
        {
            yield return new WaitForSeconds(0.3f);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = None;
            yield return new WaitForSeconds(0.3f);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Circle;
        }
    }
}
