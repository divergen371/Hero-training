using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        List<string> questPartyMembers = new List<string>()
        { "Grim the Barbalian", "Merlin the Wise", "Sterling the Knight"};

        foreach (var member in questPartyMembers)
        {
            Debug.LogFormat("{0} - Here!!", member);
        }

    }


    void Update()
    {

    }

}
