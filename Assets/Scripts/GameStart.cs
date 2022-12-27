using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public void GoBattle()
    {
        GameModeChanger mode = new GameModeChanger();
        mode.Change(GameMode.BATTLE);
    }

}
