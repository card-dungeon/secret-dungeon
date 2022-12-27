using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTitleUi : MonoBehaviour
{
    void Awake()
    {
        GameModeChanger.changeGameMode += this._changeGameMode;
    }

    void Update()
    {

    }

    private void _changeGameMode(GameMode _mode)
    {
        // TODO: GameMode가 추가되면 다른 로직 추가
        switch (_mode)
        {
            case GameMode.TITLE:
                gameObject.SetActive(true);
                break;
            case GameMode.NONE:
                throw new System.Exception("게임 모드가 올바르지 않습니다");
            default:
                gameObject.SetActive(false);
                break;
        }
    }
}
