using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CardArea : MonoBehaviour
{
    private List<GameObject> _cards = new List<GameObject>();

    void Start()
    {

    }

    void Update()
    {

    }

    public void SetCard(ref GameObject _obj)
    {
        if (this._cards.Count > 5)
        {
            throw new Exception("이 에리어에는 이미 5장의 카드가 세팅되어 있습니다");
        }

        foreach (var card in this._cards)
        {
            if (System.Object.ReferenceEquals(_obj, card))
            {
                throw new Exception("이 카드는 이미 추가되어 있습니다");
            }
        }

        this._cards.Add(_obj);
    }

    public void DeleteCard(ref GameObject _obj)
    {
        if (this._cards.Count < 1)
        {
            throw new Exception("이 에리어에는 카드가 없습니다");
        }

        for (var i = 0; i < this._cards.Count; ++i)
        {
            if (System.Object.ReferenceEquals(_obj, this._cards[i]))
            {
                this._cards.RemoveAt(i);
                return;
            }
        }

        throw new Exception("제거하려는 카드는 이 에리어에 존재하지 않습니다");
    }

    public void SetArea()
    {
        switch (this._cards.Count)
        {
            case 0: break;
            case 1: this._cards[0].transform.position = transform.position; break;
            case 2:
                this._cards[0].transform.position = transform.position + new Vector3(-0.1f, 0, 0);
                this._cards[1].transform.position = transform.position + new Vector3(0.1f, 0, 0);
                break;
            case 3:
                this._cards[0].transform.position = transform.position + new Vector3(-0.2f, 0, 0);
                this._cards[1].transform.position = transform.position;
                this._cards[2].transform.position = transform.position + new Vector3(0.2f, 0, 0);
                break;
            case 4:
                this._cards[0].transform.position = transform.position + new Vector3(-0.2f, 0, 0);
                this._cards[1].transform.position = transform.position + new Vector3(-0.07f, 0, 0);
                this._cards[2].transform.position = transform.position + new Vector3(0.07f, 0, 0);
                this._cards[3].transform.position = transform.position + new Vector3(0.2f, 0, 0);
                break;
            case 5:
                this._cards[0].transform.position = transform.position + new Vector3(-0.23f, 0, 0);
                this._cards[1].transform.position = transform.position + new Vector3(-0.12f, 0, 0);
                this._cards[2].transform.position = transform.position;
                this._cards[3].transform.position = transform.position + new Vector3(0.12f, 0, 0);
                this._cards[4].transform.position = transform.position + new Vector3(0.23f, 0, 0);
                break;
            default:
                throw new Exception("에리어의 카드의 수가 올바르지 않습니다");
        }
    }
}
