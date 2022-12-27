using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void ChangeGameMode(GameMode _mode);

public class GameManager : MonoBehaviour
{
    private GameMode _mode = GameMode.NONE;
    private GameModeChanger _gameMode = new GameModeChanger();

    void Awake()
    {
        Physics.gravity = new Vector3(0, -0.2f, 0);
        GameModeChanger.changeGameMode += this._changeGameMode;

        _gameMode.Change(GameMode.TITLE);
    }

    void Update()
    {

    }

    private void _changeGameMode(GameMode _mode)
    {
        this._mode = _mode;
    }
}

public class GameModeChanger
{
    public static event ChangeGameMode changeGameMode;

    public void Change(GameMode _mode)
    {
        changeGameMode(_mode);
    }

}