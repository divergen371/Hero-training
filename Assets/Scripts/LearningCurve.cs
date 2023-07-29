using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;
    public string rareItem = "The Soul of a Fanatic";

    void Start()
    {
        OpenTresureChamber();
    }


    void Update()
    {
        
    }

    public void OpenTresureChamber()
    {
        if (pureOfHeart && rareItem == "The Soul of a Fanatic")
        {
            if (!hasSecretIncantation)
            {
                Debug.Log("善き心を持つものよ、知識を携えてまた来るが良い。");
            }
            else
            {
                Debug.Log("真の勇者よ、汝にこそこの宝は相応しい。");
	        }
        }
        else
        {
            Debug.Log("資格を得てまた来るが良い。");
        }
    }
}
