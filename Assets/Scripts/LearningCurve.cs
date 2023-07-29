using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public bool weaponEquipped = true;
    public string weaponType = "Longsword";

    void Start()
    {
        if (weaponEquipped)
        {
            if (weaponType == "Longsword")
            {
                Debug.Log("女王陛下バンザイ");
            }
        }
        else
        {
            Debug.Log("素手では鎧武者には勝てませぬぞ…。");
	    }
    }


    void Update()
    {
        
    }
}
