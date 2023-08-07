using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameBehavior : MonoBehaviour
{
    public string labelText = "4つのアイテムをあつめて自由を勝ち取ろう！";
    public int maxItems = 4;
    public bool showWinScreen = false;
    private int _itemCollected = 0;
    public int Items
    { 
        get { return _itemCollected; }
        set { 
            _itemCollected = value;
            if (_itemCollected >= maxItems)
            {
                labelText = "アイテムを全部みつけたね！";
                showWinScreen = true;
                Time.timeScale = 0f;
            }
            else
            {
                labelText = "アイテムをみつけたね。あと " + (maxItems - _itemCollected) + "つだよ！";
            }
	    }
    }
    
    private int _playerHP = 10;
    public int HP
    { 
        get { return _playerHP; }
        set {
            _playerHP = value;
            Debug.LogFormat("Lives: {0}", _playerHP);
	    }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "プレイヤーのHP:" + _playerHP);
        GUI.Box(new Rect(20, 50, 150, 25), "あつめたアイテム:" + _itemCollected);
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);
        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100,
                Screen.height / 2 - 50, 200, 100), "きみの勝ちだ！"))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1.0f;
            }
        }
    }
}
