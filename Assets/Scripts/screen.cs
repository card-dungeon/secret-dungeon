using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screen : MonoBehaviour
{
    private GameMode _mode;

    void Awake()
    {
        Screen.SetResolution(1080, 1920, true);
        Screen.SetResolution(Screen.width, (Screen.width * 16) / 9, true);
        Camera.main.aspect = 9f / 16f;

        GameModeChanger.changeGameMode += this.SetGameMode;
    }

    void Update()
    {

    }

    public void SetGameMode(GameMode _mode)
    {
        this._mode = _mode;
        switch (this._mode)
        {
            case GameMode.TITLE:
                this.transform.position = new Vector3(-2f, 1.495f, 0);
                break;
            case GameMode.DECK_EDIT:
                this.transform.position = new Vector3(2f, 1.495f, 0);
                break;
            case GameMode.BATTLE:
                this.transform.position = new Vector3(0, 1.495f, 0);
                break;
            default:
                throw new System.Exception("지원하지 않는 게임 모드 입니다");
        }
    }
}
