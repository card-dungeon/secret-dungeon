using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // private RaycastHit _hit;
    // private GameMode _mode;
    // private float _clickTime = 0;

    // void Awake()
    // {

    // }

    // void Update()
    // {
    //     switch (this._mode)
    //     {
    //         case GameMode.DECK_EDIT:

    //             if (Input.GetMouseButtonDown(0))
    //             {

    //             }
    //             if (Input.GetMouseButton(0))
    //             {
    //                 this._clickTime += Time.deltaTime;
    //                 Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //                 // Debug.DrawRay(ray.origin, ray.direction * 1000, Color.green);

    //                 int layerMask = 1 << LayerMask.NameToLayer("Card");
    //                 if (Physics.Raycast(ray, out _hit, Mathf.Infinity, layerMask))
    //                 {
    //                     float y = _hit.transform.position.y;
    //                     _hit.transform.position = new Vector3(_hit.point.x, y, _hit.point.z);
    //                 }

    //                 layerMask = (1 << LayerMask.NameToLayer("Area")) | (1 << LayerMask.NameToLayer("Ground"));
    //                 RaycastHit[] hits = Physics.RaycastAll(ray, Mathf.Infinity, layerMask);
    //                 for (int i = 0; i < hits.Length; i++)
    //                 {
    //                     RaycastHit hit = hits[i];
    //                 }
    //             }
    //             if (Input.GetMouseButtonUp(0))
    //             {
    //                 Debug.Log(this._clickTime);
    //                 this._clickTime = 0;
    //             }
    //             break;
    //         case GameMode.BATTLE:
    //             break;
    //         case GameMode.TITLE:
    //             break;
    //         default:
    //             throw new System.Exception("지원하지 않는 게임 모드 입니다");
    //     }
    // }

    // public void SetGameMode(GameMode _mode)
    // {
    //     this._mode = _mode;
    // }
}
