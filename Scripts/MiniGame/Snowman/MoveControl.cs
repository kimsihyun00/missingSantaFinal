using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    public Vector2 correctPos;
    private bool moving;
    private bool clear = false;

    private Vector2 resetPos;
    private Vector2 startPos;

    private void Start()
    {
        resetPos = this.transform.position;
    }

    void Update()
    {
        if(moving && !clear)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.position = new Vector2(mousePos.x - startPos.x, mousePos.y - startPos.y);
        }
    }

    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPos.x = mousePos.x - this.transform.position.x;
            startPos.y = mousePos.y - this.transform.position.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;

        if(Mathf.Abs(this.transform.position.x- correctPos.x)<=0.5f &&
            Mathf.Abs(this.transform.position.y - correctPos.y) <=0.5f)
        {
            this.transform.position = new Vector2(correctPos.x, correctPos.y);
            clear = true;

            GameObject.Find("SnowmanGame").GetComponent<SnowManGame>().AddClears();
        }
        else
        {
            this.transform.position = new Vector2(resetPos.x, resetPos.y);
        }
    }
}
