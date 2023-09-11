using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileDestructible : MonoBehaviour
{
    //Spacing of each tile
    [SerializeField] private string destructString;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag(destructString))
        {
            Destroy(gameObject);
        }
    }
}
