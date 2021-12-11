using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RockStageBuilder : MonoBehaviour, IStageBuilder
{
    public GameObject parentOfStage;
    public GameObject plane;
    public GameObject wall;
    public GameObject coke;
    public GameObject Monster;
    private Stage _stage = null;
    public Stage GetStage()
    {
        return _stage;
    }
    public void MakeStage()
    {
        GameObject obj = Instantiate(parentOfStage) as GameObject;
        _stage = obj.GetComponent<Stage>();
        _stage.SetStageType(StageType.Green);
    }
    public void SetTerrain()
    {
        _stage.AddObject(plane, Vector3.zero);
        _stage.AddObject(wall, Vector3.zero);
    }
    public void SetObject()
    {
        //_stage.AddObject(plantObj, new Vector3(-9, 0.5f, 9f));

        _stage.AddObject(coke, new Vector3(9, 0.5f, 7f));
        _stage.AddObject(coke, new Vector3(9, 0.5f, -9.5f));
        _stage.AddObject(coke, new Vector3(-9, 0.5f, -9.5f));
    }
    public void SetMonster()
    {
        _stage.AddObject(Monster, Vector3.zero);
    }
}

