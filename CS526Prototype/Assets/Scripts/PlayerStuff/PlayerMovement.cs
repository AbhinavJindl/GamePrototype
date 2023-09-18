using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private float vertical;
    private float horizontal;

    private void Update()
    {
        //check if game is over
        if (GameManager.Instance.isOver)
        {
            horizontal = 0;
            vertical = 0;
            return;
        }
            
        
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
