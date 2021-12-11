using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GreenDoor : Door
{
    public override void OpenOrClose(GameObject player)
    {
        if (isClosed)
        {
            bool isGreenKey = player.GetComponent<PlayerMove>().IsGreenKey;
            if (isGreenKey)
            {
                isClosed = false;
                this.gameObject.GetComponent<MeshRenderer>().enabled = isClosed;
                this.gameObject.GetComponent<BoxCollider>().enabled = isClosed;
            }
        }
    }
    private void Start()
    {
        isClosed = true;
    }
}
