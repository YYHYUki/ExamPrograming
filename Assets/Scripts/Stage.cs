using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stage : MonoBehaviour
{
    private StageType stageType;
    public void SetStageType(StageType stageType)
    {
        this.stageType = stageType;
    }
    public void AddObject(GameObject part, Vector3 localPosition)
    {
        GameObject obj = Instantiate(part) as GameObject;
        obj.transform.localPosition = localPosition;
        obj.transform.SetParent(this.transform);
    }
    public void DeleteObject()
    {
        Transform[] trs = GetComponentsInChildren<Transform>();
        for (int i = 1; i < trs.Length; i++)
        {
            Destroy(trs[i].gameObject);
        }
        Destroy(this.gameObject);
    }
}