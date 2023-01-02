using UnityEngine;

public class BehaviourProperty : ScriptableObject
{
    [SerializeField]
    private int _bhType;
    [SerializeField]
    // private RangeType _enemyRangeType;
    // [SerializeField]
    // private RangeType _aliyRangeType;


    // public RangeType EnemyRangeType
    // {
    //     get { return this._enemyRangeType; }
    //     set { this._enemyRangeType = value; }
    // }
    // public RangeType AliyRangeType
    // {
    //     get { return this._aliyRangeType; }
    //     set { this._aliyRangeType = value; }
    // }
    public int BehaviourType
    {
        get { return this._bhType; }
        set { this._bhType = value; }
    }
}
