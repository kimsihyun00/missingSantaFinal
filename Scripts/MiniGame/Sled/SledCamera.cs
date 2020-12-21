using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SledCamera : MonoBehaviour
{
    public Vector3 CameraEnd;

    private float CameraSpeed = 10f;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, CameraEnd, CameraSpeed * Time.deltaTime);
    }

}
