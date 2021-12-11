using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum StageType
{
    Forest,
    Green
}
interface IStageBuilder
{
    Stage GetStage();
    void SetTerrain();
    void SetObject();
    void SetMonster();
}