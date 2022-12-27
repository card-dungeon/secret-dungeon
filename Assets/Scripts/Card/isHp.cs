using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class isHp : MonoBehaviour
{
    private Renderer _renderer;
    private TextMeshPro _tmp;

    void Awake()
    {
        this._renderer = gameObject.GetComponent<Renderer>();
        this._tmp = gameObject.transform.GetChild(0).GetComponent<TextMeshPro>();

        this._renderer.enabled = false;
        this._tmp.enabled = false;
    }

    public void SetVisible(bool _trig)
    {
        this._renderer.enabled = _trig;
        this._tmp.enabled = _trig;
    }

    public void SetHpText(int _hp)
    {
        if (_hp <= 0) { this.SetVisible(false); return; }

        this.SetVisible(true);
        this._tmp.text = _hp.ToString();
    }
}
