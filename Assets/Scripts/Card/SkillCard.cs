using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCard : BaseCardProperty
{
    [SerializeField]
    private BaseCardProperty Stat;
    public BaseCardProperty Property
    {
        get { return this.Stat; }
        set { this.Stat = value; }
    }
    private GameMode _mode;

    void Awake()
    {

    }

    void Update()
    {

    }
}
