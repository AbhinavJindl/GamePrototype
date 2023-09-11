using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    //Spacing of each tile
    [SerializeField] private float tileSize;

    //how many tiles from the center should spawn
    [SerializeField] private int gridSize;
    
    //tile prefab
    [SerializeField] private GameObject tile;
    
    void Start()
    {
        Vector3 location = new Vector3(gridSize * tileSize, gridSize * tileSize);
        for (int i = 0; i <= gridSize * 2; i++)
        {
            for (int j = 0; j <= gridSize * 2; j++)
            {
                Instantiate(tile, location, Quaternion.identity);
                location.x -= tileSize;
            }

            location.x = gridSize * tileSize;
            location.y -= tileSize;
        }
    }
}
