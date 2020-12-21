using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Animator DialogAppearAnim;

    public GameObject DialogPanel;

    public GameObject[] CharacterDialogPanels = new GameObject[1];
    public Text LineText;

    private Queue<int> NameNums = new Queue<int>();
    private Queue<string> Lines = new Queue<string>();

    public static bool Talking = false;

    int[] LockNameNums = { 7, 5, 6, 7 };
    string[] LockLines =
    {
        "언니!! 여기 봐!!",
        "분홍아, 일단 지금은 다른 걸 먼저 찾아보자.",
        "그래. 다른 걸 찾다보면 이따가 알 수 있을 거야.",
        "응!! 알았어.."
    };

    float Speed = 0.05f;
    int Name;
    string Line;

    public void StartDialog(ObjectLines ObjectDialogLines)
    {
        NameNums.Clear();
        Lines.Clear();
        Debug.Log("StartDialog");

        if (AnswerNote.Chapter >= ObjectDialogLines.ChapterOpen)
        {
            Debug.Log("ShouldTalk");
            for (int i = 0; i < ObjectDialogLines.NameNums.Length; i++)
            {
                NameNums.Enqueue(ObjectDialogLines.NameNums[i]);
                Lines.Enqueue(ObjectDialogLines.Lines[i]);
            }
        }
        else
        {
            Debug.Log("ShouldNotTalk");
            for (int i = 0; i < LockNameNums.Length; i++)
            {
                NameNums.Enqueue(LockNameNums[i]);
                Lines.Enqueue(LockLines[i]);
            }
        }

        DialogPanel.SetActive(true);
        CharacterDialogPanels[NameNums.Peek()].SetActive(true);
        DialogAppearAnim.SetBool("appear", true);

        StartCoroutine(DialogPanelAppear());
    }

    public void EndDialog()
    {
        DialogAppearAnim.SetBool("appear", false);

        StartCoroutine(DialogPanelDisappear());
    }

    private void DisplayDialog()
    {
        Name = NameNums.Dequeue();
        CharacterDialogPanels[Name].SetActive(true);

        StartCoroutine(TypingLine());
    }

    public IEnumerator TypingLine()
    {
        Line = Lines.Dequeue();

        for (int i = 0; i < Line.Length; i++)
        {
            LineText.text = Line.Substring(0, i + 1);
            yield return new WaitForSeconds(Speed);
        }
    }

    public IEnumerator DialogPanelAppear()
    {
        yield return new WaitForSeconds(1f);

        DisplayDialog();
    }

    public IEnumerator DialogPanelDisappear()
    {
        Talking = false;
        yield return new WaitForSeconds(1f);

        LineText.text = "";
        CharacterDialogPanels[Name].SetActive(false);
        DialogPanel.SetActive(false);
    }

    public void NextBtnClicked()
    {
        StopAllCoroutines();

        if (NameNums.Count == 0)
        {
            EndDialog();
            return;
        }

        CharacterDialogPanels[Name].SetActive(false);

        DisplayDialog();
    }
}
