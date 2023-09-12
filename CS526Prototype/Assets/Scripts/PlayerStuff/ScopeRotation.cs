using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeRotation : MonoBehaviour
{
    public float rotationSpeed = 30.0f; // Speed of the rotation.
    public Transform childToRotate;

    void Update()
    {
        // Get vertical input.
        float verticalInput = Input.GetAxis("Vertical");

        // Rotate child around the parent's position.
        childToRotate.RotateAround(transform.position, Vector3.forward, verticalInput * rotationSpeed * Time.deltaTime);
    }
}
