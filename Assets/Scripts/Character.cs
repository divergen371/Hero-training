using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "unset";
    }

    // コンストラクタ
    public Character(string name)
    {
        this.name = name;
    }
   
}