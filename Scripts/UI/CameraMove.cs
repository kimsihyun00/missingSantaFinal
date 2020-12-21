using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    bool LeftClicked = false;
    bool RightClicked = false;
    bool UpClicked = false;
    bool DownClicked = false;

    float CameraSpeed = 10f;
    
    int i = 1;
    int j = 1;

    private void Start()
    {
        LeftClicked = false;
        RightClicked = false;
        UpClicked = false;
        DownClicked = false;
        
        i = 1;
        j = 1;
    }

    void Update()
    {
        if(LeftClicked)
        {
            transform.Translate(Vector3.left * CameraSpeed * Time.deltaTime);
            if (j == 1 && transform.position.x <= 0)
                LeftClicked = false;
            if (j == 2 && transform.position.x <= 17.7f)
                LeftClicked = false;
        }

        if (RightClicked)
        {
            transform.Translate(Vector3.right * CameraSpeed * Time.deltaTime);
            if (j == 2 && transform.position.x >= 17.7f)
                RightClicked = false;
            if (j == 3 && transform.position.x >= 35.4f)
                RightClicked = false;
        }

        if (UpClicked)
        {
            transform.Translate(Vector3.up * CameraSpeed * Time.deltaTime);
            if (i == 2 && transform.position.y >= 10)
                UpClicked = false;
            if (i == 3 && transform.position.y >= 20)
                UpClicked = false;
        }

        if (DownClicked)
        {
            transform.Translate(Vector3.down * CameraSpeed * Time.deltaTime);
            if (i == 1 && transform.position.y <= 0)
                DownClicked = false;
            if (i == 2 && transform.position.y <= 10)
                DownClicked = false;
        }
    }

    public void LeftBtnClicked()
    {
        j--;
        LeftClicked = true;
    }

    public void RightBtnClicked()
    {
        j++;
        RightClicked = true;
    }
    
    public void UpBtnClicked()
    {
        i++;
        UpClicked = true;
    }

    public void DownBtnClicked()
    {
        i--;
        DownClicked = true;
    }
}
