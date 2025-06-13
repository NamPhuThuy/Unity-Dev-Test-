using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PrefabList", menuName = "ScriptableObjects/PrefabList", order = 1)]
public class PrefabList : ScriptableObject
{
    public List<GameObject> prefabs;

    public GameObject GetPrefabByName(string name)
    {
        return prefabs.Find(prefab => prefab.name == name);
    }
}