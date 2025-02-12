﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLook : MonoBehaviour
{
    public float mouseSens = 100f;

    public Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -60f, 60f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);       
    }
}
