using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterCard : MonoBehaviour
{
    [SerializeField]
    private BaseCardProperty Stat;
    public BaseCardProperty Property
    {
        get { return this.Stat; }
        set { this.Stat = value; }
    }
    private Rigidbody _rig;
    private GameObject _equipCard;
    private GameObject _skillCard;
    // 상태 이상
    private int _status;
    private Camera _camera;
    private GameMode _mode;

    void Awake()
    {
        this._rig = GetComponent<Rigidbody>();
        // this._rig.useGravity = true;
        // this._rig.freezeRotation = true;
        GameModeChanger.changeGameMode += this._changeGameMode;
    }

    void Update()
    {

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(1);
    }

    public void SetEquipCard(GameObject _gameObject)
    {
        if (!_gameObject.GetComponent<EquipCard>()) throw new System.Exception("장착하려는 카드는 장비 카드가 아닙니다");
        if (this._equipCard != null) throw new System.Exception("이미 장비 카드가 장착 되어 있습니다");

        this._equipCard = _gameObject;
    }
    public void SetSkillCard(GameObject _gameObject)
    {
        if (!_gameObject.GetComponent<SkillCard>()) throw new System.Exception("장착하려는 카드는 스킬 카드가 아닙니다");
        if (this._skillCard != null) throw new System.Exception("이미 스킬 카드가 장착 되어 있습니다");

        this._skillCard = _gameObject;
    }

    public void DeleteEquipCard()
    {
        if (this._equipCard == null) throw new System.Exception("장착하고 있는 장비 카드가 없습니다");

        this._equipCard = null;
    }

    public void DeleteSkillCard()
    {
        if (this._skillCard == null) throw new System.Exception("장착하고 있는 스킬 카드가 없습니다");

        this._skillCard = null;
    }

    private void _changeGameMode(GameMode _mode)
    {
        this._mode = _mode;
        switch (_mode)
        {
            case GameMode.DECK_EDIT:
                this._rig.useGravity = false;
                break;
            case GameMode.BATTLE:
                this._rig.useGravity = true;
                break;
            case GameMode.TITLE:
                this._rig.useGravity = false;
                break;
            default:
                break;
        }
    }

    // GETTER SETTER
    public int Status
    {
        get { return this._status; }
        set { this._status = value; }
    }
}
