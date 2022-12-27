using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCardProperty : MonoBehaviour
{
    protected int _hp;
    protected int _sd;
    protected int _spd;
    protected int _atk;
    protected int _heal;
    protected int _cooldown;
    protected RangeType _atkType;
    protected RangeType _sdType;
    protected RangeType _healType;
    protected RangeType _skillType;
    protected string _desc;
    protected CardType _cardType;

    // GETTER SETTER
    // public int Hp
    // {
    //     get { return this._hp; }
    //     set { this._hp = value; }
    // }
    // public int Spd
    // {
    //     get { return this._spd; }
    //     set { this._spd = value; }
    // }
    // public int Sd
    // {
    //     get { return this._sd; }
    //     set { this._sd = value; }
    // }
    // public int Atk
    // {
    //     get { return this._atk; }
    //     set { this._atk = value; }
    // }
    // public int Heal
    // {
    //     get { return this._heal; }
    //     set { this._heal = value; }
    // }
    // public int Cooldown
    // {
    //     get { return this._cooldown; }
    //     set { this._cooldown = value; }
    // }
    // public RangeType SdType
    // {
    //     get { return this._sdType; }
    //     set { this._sdType = value; }
    // }
    // public RangeType AtkType
    // {
    //     get { return this._atkType; }
    //     set { this._atkType = value; }
    // }
    // public RangeType HealType
    // {
    //     get { return this._healType; }
    //     set { this._healType = value; }
    // }
    // public RangeType SkillType
    // {
    //     get { return this._skillType; }
    //     set { this._skillType = value; }
    // }
    // public string Desc
    // {
    //     get { return this._desc; }
    //     set { this._desc = value; }
    // }
    // public CardType Type
    // {
    //     get { return this._cardType; }
    //     set { this._cardType = value; }
    // }
}
