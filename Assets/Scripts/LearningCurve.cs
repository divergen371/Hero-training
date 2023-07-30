using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        Character hero = new Character();
        hero.PrintStatsInfo();
        Character heroine = new Character("アガサ");
        heroine.PrintStatsInfo();
    }


    void Update()
    {

    }

}
