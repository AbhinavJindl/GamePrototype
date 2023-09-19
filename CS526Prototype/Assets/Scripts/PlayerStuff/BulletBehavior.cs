using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    
    [SerializeField] private string wallTag;
    [SerializeField] private string bounceTag;
    [SerializeField] private string lethalTag;
    [SerializeField] private MoveForward _moveForward;
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
            //get normal from the closest point
            //calculate from position of last frame of bullet
            Vector3 vecTemp = transform.position -= transform.up * _moveForward.speed * Time.deltaTime;
            Vector3 closestPoint = col.ClosestPoint(vecTemp);
            Vector3 normal = vecTemp - closestPoint;
            
            //normalize
            normal.Normalize();
            
            //create reflection vector
            Vector3 reflectVec = transform.up - 2 * Vector3.Dot(transform.up, normal) * normal;
            transform.up = reflectVec;
            StartCoroutine(ResetBullet());
        }
        //only process this if currently not bouncing
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

    IEnumerator ResetBullet()
    {
        yield return new WaitForSeconds(0.02f);
        isBouncing = false;
    }
}
