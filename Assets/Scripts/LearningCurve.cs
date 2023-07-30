using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        List<string> questPartyMembers = new List<string>()
        { "Grim the Barbalian", "Merlin the Wise", "Sterling the Knight"};

        for (int i = 0; i <questPartyMembers.Count ; i++)
        {
            if (questPartyMembers[i] == "Merlin the Wise")
           {
                Debug.Log($"Glad you're here, {questPartyMembers[i]}.");
	       }
        }

    }


    void Update()
    {

    }

}
