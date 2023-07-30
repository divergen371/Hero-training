using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        List<string> questPartyMembers = new List<string>()
        { "Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"};
        questPartyMembers.Add("Craven the Necromancer");
        questPartyMembers.Insert(1, "Tanis the Thief");
        
        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);
    }


    void Update()
    {
        
    }

}
