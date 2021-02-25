using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprites : MonoBehaviour
{
    public UnityEngine.U2D.SpriteAtlas spriteAtlas;
    private Dictionary<string, Sprite> cachedSprites = new Dictionary<string, Sprite>();

    public Sprite LoadSpriteByName(string name)
    {
        Sprite foundSprite;
        cachedSprites.TryGetValue(name, out foundSprite);
        if(foundSprite)
        {
            return foundSprite;
        }
        foundSprite = spriteAtlas.GetSprite(name);
        if(foundSprite == null)
        {
            return null;
        }
        cachedSprites[name] = foundSprite;
        return foundSprite;
    }
    
}
