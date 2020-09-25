using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArrow : MonoBehaviour
{
    public GameObject arrowPrefab;
    public GameObject [] locations;
    public int location;

    void Spawn()
    {
        if (locations.Length == 0)
        {
            Instantiate(arrowPrefab, transform.position + new Vector3(0, 3, 1), Quaternion.identity);
        }
        else
        {
            Instantiate(arrowPrefab, locations[location].transform.position, locations[location].transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Spawn();
        }
    }
}
