using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;

    //floats for movement
    private float vert;
    private float horiz;

    [SerializeField] private string wallTag;
    [SerializeField] private string bounceTag;
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
        rigidbody.MovePosition(rigidbody.position + pos * Time.deltaTime * 40);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag(wallTag))
        {
            Destroy(gameObject);
        }
        else if (col.gameObject.CompareTag(bounceTag))
        {
            
        }
    }
}