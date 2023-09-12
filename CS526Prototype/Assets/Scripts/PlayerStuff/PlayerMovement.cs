using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    private void Start()
    {
    }

    private void Update()
    {
        // Get horizontal and vertical input (A/D and W/S respectively).
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0.0f).normalized;

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

}
