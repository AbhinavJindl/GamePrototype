using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapDestructable : MonoBehaviour
{
    private Tilemap destructableTilemap;
    // Start is called before the first frame update
    void Start()
    {
        destructableTilemap = GetComponent<Tilemap>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        /*if (col.gameObject.CompareTag("Player"))
        {
            Vector3 hitPosition = Vector3.zero;
            foreach (ContactPoint2D hit in col.contacts)
            {
                Vector3 normal = hit.normal * -1;
                hitPosition.x = hit.point.x - 0.1f * normal.x;
                hitPosition.y = hit.point.y - 0.1f * normal.y;
                Debug.Log("Hit position: " + hitPosition);
                Debug.Log("Normal position: " + hit.normal);
                destructableTilemap.SetTile(destructableTilemap.WorldToCell(hitPosition), null);
            }
        }*/
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        /*if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 hitPosition = Vector3.zero;
            foreach (ContactPoint2D hit in collision.contacts)
            {
                Vector3 normal = hit.normal * -1;
                hitPosition.x = hit.point.x - 0.1f * normal.x;
                hitPosition.y = hit.point.y - 0.1f * normal.y;
                Debug.Log("Hit position: " + hitPosition);
                Debug.Log("Normal position: " + hit.normal);
                destructableTilemap.SetTile(destructableTilemap.WorldToCell(hitPosition), null);
            }
        }*/
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("TESTING");
        ContactFilter2D contactFilter = new ContactFilter2D();
        Collider2D[] overlappingObjects = new Collider2D[]{};
        col.OverlapCollider(contactFilter, overlappingObjects);
        if (col.gameObject.CompareTag("Player"))
        {
            /*Vector3 hitPosition = Vector3.zero;
            foreach (Collider2D hit in overlappingObjects)
            {
                Vector3 normal = hit.normal * -1;
                hitPosition.x = hit.point.x - 0.1f * normal.x;
                hitPosition.y = hit.point.y - 0.1f * normal.y;
                Debug.Log("Hit position: " + hitPosition);
                Debug.Log("Normal position: " + hit.normal);
                destructableTilemap.SetTile(destructableTilemap.WorldToCell(hitPosition), null);
            }*/
        }
    }
}
