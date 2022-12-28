using UnityEngine;

[CreateAssetMenu(fileName = "base card data", menuName = "Scriptable Object/card data")]
public class BaseCardProperty : ScriptableObject
{
    [SerializeField]
    private int _hp;
    [SerializeField]
    private int _sd;
    [SerializeField]
    private int _spd;
    [SerializeField]
    private int _atk;
    [SerializeField]
    private int _heal;
    [SerializeField]
    private int _cooldown;
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _desc;
    [SerializeField]
    private CardType _cardType;

    // GETTER SETTER
    public int Hp
    {
        get { return this._hp; }
        set { this._hp = value; }
    }
    public int Spd
    {
        get { return this._spd; }
        set { this._spd = value; }
    }
    public int Sd
    {
        get { return this._sd; }
        set { this._sd = value; }
    }
    public int Atk
    {
        get { return this._atk; }
        set { this._atk = value; }
    }
    public int Heal
    {
        get { return this._heal; }
        set { this._heal = value; }
    }
    public int Cooldown
    {
        get { return this._cooldown; }
        set { this._cooldown = value; }
    }
    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }
    public string Desc
    {
        get { return this._desc; }
        set { this._desc = value; }
    }
    public CardType CardType
    {
        get { return this._cardType; }
        set { this._cardType = value; }
    }
}
