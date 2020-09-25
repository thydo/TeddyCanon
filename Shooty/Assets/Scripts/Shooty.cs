using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooty : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    GameObject bullet;
    public Transform spawnLocation;
    public float fireRate;
    private float timer;
    private int ammo = 3;

    // Update is called once per frame
    
    void Update()
    {
      
        if(Input.GetKey(KeyCode.Mouse0) && timer < 0 && ammo >0)
            {
                bullet = Instantiate(bulletPrefab, spawnLocation.position, spawnLocation.rotation);
                //print(bullet.GetComponent<Rigidbody>().velocity);
                bullet.GetComponent<Rigidbody>().velocity = spawnLocation.forward * 10;
                //print(bullet.getComponent<Rigidbody>().velocity);
                timer = fireRate;
                ammo--;
            }
        timer -= Time.deltaTime;
    }
    void OnTriggerEnter (Collider collide)
    {
        if (collide.gameObject.tag == "Box")
        {
            ammo = 1;
        }
    }

    
}
