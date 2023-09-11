using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    private float vert;

    private float horiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vert = Input.GetAxis("Vertical");
        horiz = Input.GetAxis("Horizontal");
       
    }

    void FixedUpdate()
    {
        Vector2 pos = new Vector2(horiz, vert);
        rb.MovePosition(rb.position + pos * Time.deltaTime * 40);
    }
}
