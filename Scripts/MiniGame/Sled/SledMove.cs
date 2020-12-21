using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SledMove : MonoBehaviour
{
    private Vector2 sledPos;

    public GameObject ClearBtn;
    public GameObject LeftBtn;
    public GameObject RightBtn;

    public Text countText;

    private bool leftClicked = false;
    private bool rightClicked = false;

    private float speed = 10f;

    private void Start()
    {
        sledPos = transform.position;
        Time.timeScale = 0f;
        StartCoroutine(CountDown());
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, sledPos, speed * Time.deltaTime);

        if (leftClicked && this.transform.position.x > -3.5f)
        {
            sledPos = new Vector2(transform.position.x - 3.5f, transform.position.y);
            transform.position = sledPos;
        }

        if (rightClicked && this.transform.position.x < 3.5f)
        {
            sledPos = new Vector2(transform.position.x + 3.5f, transform.position.y);
            transform.position = sledPos;
        }

        sledPos.y += 2f;

        if (this.transform.position.y >= 103f)
        {
            sledPos = new Vector2(sledPos.x, 103f);
            ClearBtn.SetActive(true);
            LeftBtn.SetActive(false);
            RightBtn.SetActive(false);
            SledGame.SledClear = true;
        }

        leftClicked = false;
        rightClicked = false;
    }

    public void SledLeftBtnClicked()
    {
        leftClicked = true;
    }

    public void SledRightBtnClicked()
    {
        rightClicked = true;
    }

    IEnumerator CountDown()
    {
        int count = 3;
        while (count > 0)
        {
            countText.text = count.ToString("0");
            yield return new WaitForSecondsRealtime(1);
            count--;
        }
        countText.text = "";

        Restart();
    }

    void Restart()
    {
        Time.timeScale = 1f;
    }
}
