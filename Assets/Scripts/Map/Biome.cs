using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CreateBiome")]
public class Biome : SerializedScriptableObject
{
    public string id;
    public Dictionary<string, WorldTile> tiles;
}
