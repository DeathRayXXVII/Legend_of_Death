using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBehavior2 : MonoBehaviour
{
    private bool canSpawn;
    public float randomSpawningTime = 10; 
    public PoolController poolControlObj;

    /*private void OnTriggerEnter(Collider other)
    {
        canSpawn = true;
        StartCoroutine(ActivatePooling()); 
    }

    private void OnTriggerExit(Collider other)
    {
        canSpawn = false;
    }

    private IEnumerator ActivatePooling()
    {
        while (canSpawn)
        {
            yield return new WaitForSeconds(Random.Range(0, randomSpawningTime));
            poolControlObj.ActivateObj(transform.position);
        }
    }*/
    public void ActivatePooling()
    {
        poolControlObj.ActivateObj(transform.position);
    }
}
