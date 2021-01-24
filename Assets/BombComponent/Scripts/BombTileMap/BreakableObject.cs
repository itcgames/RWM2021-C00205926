using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class BreakableObject : MonoBehaviour
{
    public Tilemap tm;

    public Tile breakTile;
    public Tile unbreakableTile;
    public GameObject effectedTiles;

    public int range;


    public void Boom(Vector2 worldpos)
    {
        Vector3Int centerIndex = tm.WorldToCell(worldpos);
        TilesEffected(centerIndex);

        for(int i = 1;  i < range; i++)
        {
            
            TilesEffected(centerIndex + new Vector3Int(i, 0, 0));
            TilesEffected(centerIndex + new Vector3Int(0, i, 0));
            TilesEffected(centerIndex + new Vector3Int(-i, 0, 0));
            TilesEffected(centerIndex + new Vector3Int(0, -i, 0));
            
        }
    }

    bool TilesEffected(Vector3Int index)
    {
        Tile checkTile = tm.GetTile<Tile>(index);

        if(checkTile == unbreakableTile)
        {
            return false;
        }
        else if(checkTile == breakTile)
        {
            tm.SetTile(index, null);
        }

        Vector3 effected = tm.GetCellCenterWorld(index);

        Instantiate(effectedTiles, effected, Quaternion.identity);

        return true;
    }
}
