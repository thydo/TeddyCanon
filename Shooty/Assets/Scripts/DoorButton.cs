using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public GameObject door;                     //This is a reference to the door we want to open that we will be able to set on the editor
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            door.GetComponent <MoveDoor>().Move();
        }
}
}


