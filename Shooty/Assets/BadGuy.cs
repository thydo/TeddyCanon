using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Teddy")
        {
            Destroy(gameObject); 
        }
        
    }
}
