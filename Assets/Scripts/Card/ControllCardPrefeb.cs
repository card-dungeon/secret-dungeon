using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllCardPrefeb : MonoBehaviour
{
    private GameObject _hp;
    private GameObject _sd;
    private GameObject _cd;
    private GameObject _atk;
    private GameObject _heal;

    void Awake()
    {
        this._hp = transform.GetChild(0).gameObject;
        this._sd = transform.GetChild(1).gameObject;
        this._cd = transform.GetChild(2).gameObject;
        this._atk = transform.GetChild(3).gameObject;
        this._heal = transform.GetChild(4).gameObject;
    }

    public void EnableHp()
    {
        this._hp.SetActive(true);
    }
    public void DisableHp()
    {
        this._hp.SetActive(false);
    }

    public void EnableShied()
    {
        this._sd.SetActive(true);
    }
    public void DisableShied()
    {
        this._sd.SetActive(false);
    }

    public void EnableCooldown()
    {
        this._cd.SetActive(true);
    }
    public void DisableCooldown()
    {
        this._cd.SetActive(false);
    }

    public void EnableAttack()
    {
        this._atk.SetActive(true);
    }
    public void DisableAttack()
    {
        this._atk.SetActive(false);
    }

    public void EnableHeal()
    {
        this._heal.SetActive(true);
    }
    public void DisableHeal()
    {
        this._heal.SetActive(false);
    }
}
