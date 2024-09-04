using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] float sesitivity = 8f; // ���콺 �ΰ���
    public float rotationX = 0f; // = X�� ��ġ
    public float rotationY = 0f; // = Y�� ��ġ

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
        // �¿�� ���������ִ� �ڵ� �̱��� (��� �����ϸ� �������?)

        transform.localEulerAngles = new Vector3 (rotationY, rotationX, 0);
    }
}
