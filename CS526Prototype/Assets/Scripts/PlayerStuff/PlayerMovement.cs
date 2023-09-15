using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private float vertical;
    private float horizontal;

    private void Start()
    {
    }

    private void Update()
    {
        // Get horizontal and vertical input (A/D and W/S respectively).
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(horizontal, vertical, 0.0f);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }

}
