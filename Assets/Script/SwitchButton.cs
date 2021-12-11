using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SwitchButton : MonoBehaviour
{
    public Door YelloDoor;
    public Door BlueDoor;
    public Door GreenDoor;
    List<Door> doors = new List<Door>();
    public void AddDoor(Door d)
    {
        doors.Add(d);
    }
    public void RemoveDoor(Door d)
    {
        if (doors.Contains(d))
            doors.Remove(d);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            foreach (Door d in doors)
                d.OpenOrClose(other.gameObject);
        }
    }
    private void Start()
    {
        AddDoor(YelloDoor);
        AddDoor(BlueDoor);
        AddDoor(GreenDoor);
    }
}