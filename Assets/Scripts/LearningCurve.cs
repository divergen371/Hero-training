using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int characterLevel = 32;
        GenerateCharacter("Spike", characterLevel);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);
    }
}
