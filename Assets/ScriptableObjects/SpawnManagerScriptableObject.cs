using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Spawn Manager", menuName = "Spawn Manager")]

public class SpawnManagerScriptableObject : ScriptableObject
{


    public string prefabName;
    public int spawnCount;
    public float timeBetweenSpawns;

}
