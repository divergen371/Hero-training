using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        Character hero = new Character();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
        Character heroine = new Character("アガサ");
        Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);
    }


    void Update()
    {

    }

}
