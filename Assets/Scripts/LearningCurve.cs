using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public bool hasDurgeonKey = true;

    // Start is called before the first frame update
    void Start()
    {
        if (hasDurgeonKey)
        {
            Debug.Log("秘密の鍵をお持ちだね。通りなさい。");
        }
        else
        {
            Debug.Log("戦士よ、身の証しを立てねば通せぬぞ。");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
