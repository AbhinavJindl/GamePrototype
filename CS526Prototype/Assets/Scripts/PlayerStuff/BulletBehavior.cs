using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    
    [SerializeField] private string wallTag;
    [SerializeField] private string bounceTag;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (wallTag != "" && col.gameObject.CompareTag(wallTag))
        {
            Destroy(gameObject);
        }
        else if (bounceTag != "" && col.gameObject.CompareTag(bounceTag))
        {
            Vector3 closestPoint = col.ClosestPoint(transform.position);
            Vector3 normal = transform.position - closestPoint;
            normal.Normalize();
            Vector3 reflectVec = transform.up - 2 * Vector3.Dot(transform.up, normal) * normal;
            transform.up = reflectVec;
        }
    }
}
