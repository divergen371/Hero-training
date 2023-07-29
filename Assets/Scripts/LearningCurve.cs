using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentGold = 32;

    void Start()
    {
        if (currentGold > 50 )
        {
            Debug.Log("旦那は金持ちだねぇ。スリに用心しとくんだね。");
        }
        else if (currentGold < 15)
        {
            Debug.Log("ちぇっ、しけてんなぁ。おととい来やがれ。");
	    }
        else
        {
            Debug.Log("ちょうどいい塩梅だ。まいど‼");
        }
    }


    void Update()
    {
        
    }
}
