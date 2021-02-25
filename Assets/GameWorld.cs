using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameWorld : MonoBehaviour
{
    public TileBase t;
    public WorldCell[] worldCells;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderWorld();
    }

    public void RenderWorld()
    {
        Sprites sprites = GameObject.Find("Sprites").GetComponent<Sprites>();
        Tilemap tm = GetComponentInChildren<Tilemap>();
        for(int i = 0; i < 9; i++)
        {
            var xCellOffset = (2 - (i / 3)) * 25;
            var yCellOffset = (2 - (i % 3)) * 25;
            if (worldCells[i] != null)
            {
                worldCells[i].Draw(tm, xCellOffset, yCellOffset);
            }
        }
    }
}
