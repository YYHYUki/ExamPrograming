using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BlueDoor : Door
{
    private int openTryCount;
    public override void OpenOrClose(GameObject player)
    {
        if (isClosed)
        {
            ++openTryCount;
            if (openTryCount == 2)
            {
                isClosed = false;
                this.gameObject.GetComponent<MeshRenderer>().enabled = isClosed;
                this.gameObject.GetComponent<BoxCollider>().enabled = isClosed;
            }
        }
    }
    void Start()
    {
        isClosed = true;
        openTryCount = 0;
    }
}