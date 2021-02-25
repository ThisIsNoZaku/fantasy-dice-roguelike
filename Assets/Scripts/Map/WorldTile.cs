using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[ExecuteAlways]
public class WorldTile : MonoBehaviour
{
    [SerializeField]
    private Sprites sprites;
    private SpriteRenderer spriteRenderer;
    public string terrainSprite;
    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        sprites = GameObject.Find("Sprites").GetComponent<Sprites>();
    }

    // Update is called once per frame
    void Update()
    {
        if(terrainSprite != null)
        {
            spriteRenderer.sprite = sprites.LoadSpriteByName(terrainSprite);
        }
    }

    public Sprite sprite
    {
        get
        {
            return this.spriteRenderer.sprite;
        }
    }

    public class TileMapTile : TileBase
    {

    }
}
