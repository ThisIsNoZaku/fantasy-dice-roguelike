using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class WorldCell : MonoBehaviour
{
    public WorldTile[] tiles = new WorldTile[9];
    public void Draw(UnityEngine.Tilemaps.Tilemap tm, int xOffset, int yOffset)
    {
        for(int i = 0; i < tiles.Length; i++)
        {
            var worldX = (i % 25) + xOffset;
            var worldY = (i / 25) + yOffset;
            var tile = tiles[i];
            Tile mapTile = tm.GetTile(new Vector3Int(worldX, worldY, 0)) as Tile;
            mapTile.sprite = tile.sprite;
        }
    }
}
