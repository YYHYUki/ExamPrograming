using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StageBuilderUse : MonoBehaviour
{
    private StageCreator creator = null;
    private RockStageBuilder forestBuilder = null;
    private GreenStageBuilder desertBuilder = null;
    void Start()
    {
        creator = new StageCreator();
        forestBuilder = GetComponent<RockStageBuilder>();
        desertBuilder = GetComponent<GreenStageBuilder>();
        forestBuilder.MakeStage();
        creator.Construct(forestBuilder);
    }
    public void ClickedStage1()
    {
        Stage stage = desertBuilder.GetStage();
        if (stage != null)
            stage.DeleteObject();
        else
            return;
        forestBuilder.MakeStage();
        creator.Construct(forestBuilder);
    }
    public void ClickedStage2()
    {
        Stage stage = forestBuilder.GetStage();
        if (stage != null)
            stage.DeleteObject();
        else
            return;
        desertBuilder.MakeStage();
        creator.Construct(desertBuilder);
        Stage curStage = desertBuilder.GetStage();
        curStage.transform.Rotate(Vector3.up, 90);
    }
}