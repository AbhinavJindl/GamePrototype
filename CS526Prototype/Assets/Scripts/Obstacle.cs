using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Transform[] path;
    private int index = 0;
    [SerializeField] private float speed = 7.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToDestination = path[index].position - transform.position;
        if (directionToDestination.magnitude > 1)
        {
            directionToDestination.Normalize();
            transform.position += directionToDestination * speed * Time.deltaTime;
        }
        else
        {
            index++;
            if (index >= path.Length)
            {
                index = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.Die();
        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
        }
    }
}
