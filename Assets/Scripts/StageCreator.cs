using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class StageCreator
{
    public void Construct(IStageBuilder stageBuilder)
    {
        stageBuilder.SetTerrain();
        stageBuilder.SetObject();
        stageBuilder.SetMonster();
    }
}
