using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        Character hero = new Character();
        hero.PrintStatsInfo();
        Character hero2 = hero;
        hero2.name = "Sir Krane the Brave";
        
        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();
        hero2.Reset();

        Character heroine = new Character("アガサ");
        heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;

        warBow.name = "War Bow";
        warBow.damage = 155;
        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();
    }


    void Update()
    {

    }

}
