using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    // Sensitivity
    public float sensY;
    public float sensX;

    public Transform orientation;

    float xRotation, yRotation;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void Update()
    {
        // MOUSE INPUT
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= Mathf.Clamp(xRotation, -90f, 90f);

        // Rotate camera and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);

        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
