using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    
    [SerializeField] private string wallTag;
    [SerializeField] private string bounceTag;
    [SerializeField] private string lethalTag;
    private bool isBouncing = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        StartCoroutine(HandleBulletStuff(col));
    }

    IEnumerator HandleBulletStuff(Collider2D col)
    {
        if (bounceTag != "" && col.gameObject.CompareTag(bounceTag))
        {
            isBouncing = true;
            Vector3 closestPoint = col.ClosestPoint(transform.position);
            Vector3 normal = transform.position - closestPoint;
            normal.Normalize();
            Vector3 reflectVec = transform.up - 2 * Vector3.Dot(transform.up, normal) * normal;
            transform.up = reflectVec;
        }
        else if (wallTag != "" && col.gameObject.CompareTag(wallTag))
        {
            yield return new WaitForSeconds(0.01f);
            if (!isBouncing)
            {
                Destroy(gameObject);
            }
        }
        else if (lethalTag != "" && col.gameObject.CompareTag(lethalTag))
        {
            yield return new WaitForSeconds(0.01f);
            if (!isBouncing)
            {
                GameManager.Instance.Die();
                Destroy(gameObject);
            }
        }

        yield return null;
    }
}
