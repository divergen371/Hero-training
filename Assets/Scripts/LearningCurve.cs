using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        int wallet = 100;
        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            {"Potion", 100 },
            {"Antidote", 150 },
            {"Aspirin", 200 },
        };
        foreach (KeyValuePair<string, int>  kpv in itemInventory)
        {
            if (wallet >= kpv.Value)
            {
                Debug.LogFormat("{0}  can be bought.", kpv.Key);
            }
            else
            {
                Debug.LogFormat("I can't afford {0} because I don't have enough on hand.", kpv.Key);
	        }
        }

    }


    void Update()
    {

    }

}
