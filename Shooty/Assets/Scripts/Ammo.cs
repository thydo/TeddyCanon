using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBOX : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotateAmmo;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateAmmo * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Playa")
        {
            Destroy(gameObject);
        }
    }
}
