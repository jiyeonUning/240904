using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] float sesitivity = 8f; // 마우스 민감도
    public float rotationX = 0f; // = X축 위치
    public float rotationY = 0f; // = Y축 위치

    void LateUpdate()
    {
        if (Input.GetMouseButton(1) == false) return;
        MouseMove();
    }

    void MouseMove()
    {
        rotationX += Input.GetAxis("Mouse X") * sesitivity;
        rotationY -= Input.GetAxis("Mouse Y") * sesitivity;

        rotationY = Mathf.Clamp(rotationY, -90f, 90f);
        // 좌우로 고정시켜주는 코드 미구현 (어떻게 구현하면 좋을까요?)

        transform.localEulerAngles = new Vector3 (rotationY, rotationX, 0);
    }
}
