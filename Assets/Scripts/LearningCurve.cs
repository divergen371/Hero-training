using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            {"Potion", 5},
            {"Antidote", 8},
            {"Aspirin", 1},
        };
        Debug.LogFormat("Items: {0}", itemInventory.Count);
    }


    void Update()
    {

    }

}
