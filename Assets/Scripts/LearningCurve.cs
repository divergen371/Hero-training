using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 30;
    public int addedAge = 1;

    public float pi = 3.1415f;
    public string firstName = "Harrison";
    public bool isAuthor = true;
    // Start is called before the first frame update
    void Start()
    {
        GenerateCharacter();
    }


    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateCharacter()
    {
        Debug.Log("Character Spike"); 
    }
}
