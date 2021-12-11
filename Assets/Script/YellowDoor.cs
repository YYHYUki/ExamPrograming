using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class YellowDoor : Door
{
    public override void OpenOrClose(GameObject player)
    {
        isClosed = !isClosed;
        this.gameObject.GetComponent<MeshRenderer>().enabled = isClosed;
        this.gameObject.GetComponent<BoxCollider>().enabled = isClosed;
    }
    void Start()
    {
        isClosed = true;
    }
}
