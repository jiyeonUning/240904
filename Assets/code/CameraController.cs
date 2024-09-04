using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] float sesitivity = 8f; // 마우스 민감도
    public float rotationX = 0f; // = X축 위치
    public float rotationY = 0f; // = Y축 위치

    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;

    void LateUpdate()
    {
        MouseMove();
        if (Input.GetMouseButton(1) == false) return;
        MouseRotate();
    }

    void MouseRotate()
    {
        rotationX += Input.GetAxis("Mouse X") * sesitivity;
        rotationY -= Input.GetAxis("Mouse Y") * sesitivity;

        rotationY = Mathf.Clamp(rotationY, -90f, 90f);
        transform.localEulerAngles = new Vector3 (rotationY, rotationX, 0);
    }

    void MouseMove()
    {
        transform.position = target.position + offset;
        transform.LookAt(transform.position);
    }
}
