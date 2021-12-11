using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool isGreenKey;
    public bool IsGreenKey { get => isGreenKey; set => isGreenKey = value; }

    public float speed;
    float hAxis;
    float vAxis;

    Vector3 move;
    void Start()
    {
        IsGreenKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        move = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += move * speed * Time.deltaTime;
    }
}
