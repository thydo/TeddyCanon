using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotateAmmo;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateAmmo * Time.deltaTime);
    }

    Boolean OnTriggerEnter (Collider other)
    {
        if (other.gameObject.name == "Playa")
        {
            Destroy(gameObject);
            return true;
        }
        else
        {
            return false;
        }
    }
}
