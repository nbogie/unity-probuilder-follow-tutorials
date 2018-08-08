using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCarrier : MonoBehaviour
{

    private bool carry;

    [SerializeField]
    private bool isCameraCarrier;
    [SerializeField]
    private Vector3 offsetVector;

    void Start()
    {
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleCameraCarry();
        }
    }

    private void ToggleCameraCarry()
    {
        carry = !carry;
        UpdatCameraForCarryState();
    }

    private void UpdatCameraForCarryState()
    {
        if (isCameraCarrier)
        {
            if (carry)
            {
                Camera.main.transform.SetParent(transform);
                Camera.main.transform.localPosition = offsetVector;
                Camera.main.transform.LookAt(gameObject.transform.position + Vector3.up*2, Vector3.up);

            }
            else
            {
                Camera.main.transform.SetParent(null);
            }
        }
    }
}
