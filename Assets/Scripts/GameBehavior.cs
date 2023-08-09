using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CustomExtensions;


public class GameBehavior : MonoBehaviour, IManager
{
    private string _state;
    public string State
    { 
        get { return _state; }
        set { _state = value; }
    } 
    public string labelText = "4つのアイテムをあつめて自由を勝ち取ろう！";
    public int maxItems = 4;
    public bool showWinScreen = false;
    public Stack<string> lootStack = new Stack<string>();

    public bool showLoseScreen = false;
    private int _itemCollected = 0;
    public int Items
    {
        get { return _itemCollected; }
        set
        {
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

    private int _playerHP = 3;
    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            if (_playerHP <= 0)
            {
                labelText = "もうひとつライフがほしい？";
                showLoseScreen = true;
                Time.timeScale = 0f;
            }
            else
            {
                labelText = "いててっ… やられたぜ。";
            }
        }
    }

    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        _state = "ManagerのHPを初期化を終えました";
        _state.FancyDebug();
        Debug.Log(_state);

        lootStack.Push("Sowrd of Doom");
        lootStack.Push("HP+");
        lootStack.Push("Golden Key");
        lootStack.Push("Winged Boor");
        lootStack.Push("Mythril Bracers");
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
                Utilities.RestartLevel(0);
            }
        }

        if (showLoseScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "きみの負けだ…"))
            {
                Utilities.RestartLevel();
            }
        }
    }

    public void PrintLootReport()
    {
        Debug.LogFormat("お宝が{0}つ、君を待っているぞ！", lootStack.Count);
     }
}
