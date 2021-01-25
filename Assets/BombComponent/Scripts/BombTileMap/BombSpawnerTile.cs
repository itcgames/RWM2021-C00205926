using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

/// <summary>
/// If script is placed on a player then it will spawn on the corrissponding player
/// </summary>

public class BombSpawnerTile : MonoBehaviour
{
    
    public Tilemap tm;
    public GameObject[] unplantable;
    public GameObject bomb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseToWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3Int index = tm.WorldToCell(mouseToWorld);

            Vector3 centreBomb = tm.GetCellCenterWorld(index);

            Instantiate(bomb, centreBomb, Quaternion.identity);
        }
    }
}
