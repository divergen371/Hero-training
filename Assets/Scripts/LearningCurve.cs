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
        int diceRoll = 7;

        switch (diceRoll)
        {
            case 7:
            case 15:
                Debug.Log("微妙な手応え");
                break;
            case 20:
                Debug.Log("急所に当てた");
                break;
            default:
                Debug.Log("攻撃を外した");
                break;
        }
    }


    void Update()
    {
        
    }

}
