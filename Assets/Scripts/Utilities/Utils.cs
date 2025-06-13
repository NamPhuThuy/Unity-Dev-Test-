using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using URandom = UnityEngine.Random;

public class Utils
{
    public static NormalItem.eNormalType GetRandomNormalType()
    {
        Array values = Enum.GetValues(typeof(NormalItem.eNormalType));
        NormalItem.eNormalType result = (NormalItem.eNormalType)values.GetValue(URandom.Range(0, values.Length));

        return result;
    }
    
    public static NormalItem.eNormalType GetRandomNormalType(NormalItem.eNormalType[] types)
    {
        for (var i = 0; i < types.Length; i++)
        {
            Debug.Log($"Type {i}: {types[i]}");
        }
        NormalItem.eNormalType result = (NormalItem.eNormalType)types.GetValue(URandom.Range(0, types.Length));

        return result;
    }

    public static NormalItem.eNormalType GetRandomNormalTypeExcept(NormalItem.eNormalType[] types)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        /*Debug.Log($"Except list");
        foreach (NormalItem.eNormalType eNormalType in types)
        {
            Debug.Log(eNormalType.ToString());
        }
        Debug.Log($"-------------------");
        
        Debug.Log($"Remain list");
        foreach (NormalItem.eNormalType eNormalType in list)
        {
            Debug.Log(eNormalType.ToString());
        }
        Debug.Log($"-------------------");*/
        
        
        int rnd = URandom.Range(0, list.Count);
        NormalItem.eNormalType result = list[rnd];

        return result;
    }
}
