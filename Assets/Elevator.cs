using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
                   
public class Elevator : MonoBehaviour {
    private RigidbodyFirstPersonController controller;
    [SerializeField]
    private float jumpForceExtra;
    [SerializeField]
    private float jumpForceNormal;

    private void OnTriggerEnter(Collider other)
    {
        controller = other.GetComponent<RigidbodyFirstPersonController>();
        if (controller)
        {
            controller.movementSettings.JumpForce = jumpForceExtra;
            controller.advancedSettings.airControl = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        controller = other.GetComponent<RigidbodyFirstPersonController>();
        if (controller)
        {
            controller.movementSettings.JumpForce = jumpForceNormal;
            controller.advancedSettings.airControl = false;
        }
    }

}
