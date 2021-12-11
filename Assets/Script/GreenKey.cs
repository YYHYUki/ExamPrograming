using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GreenKey : MonoBehaviour
{
   
    static GameObject b;
    static int a = 3;

    private void Awake()
    {
        b = GameObject.FindGameObjectWithTag("GameOver");
    }

    private void Start()
    {
        b.GetComponent<Text>().text="";
        a = 3;
    }
    private void OnDestroy()
    {
       
        if (a==0)
        {
           //Debug.Log(b.name);
                b.GetComponent<Text>().text = "Game Over";
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            --a;
            other.gameObject.GetComponent<PlayerMove>().IsGreenKey = true;
            Destroy(this.gameObject);
        }
    }
}