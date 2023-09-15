using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10.0f;
    public float lifetime = 10.0f;

    private void Start()
    {
        StartCoroutine(Die());
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    
    IEnumerator Die()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);
    }
}
