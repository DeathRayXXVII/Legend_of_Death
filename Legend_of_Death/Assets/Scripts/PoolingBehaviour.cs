using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PoolingBehaviour : MonoBehaviour
{
    public bool canRun;
    public List<Transform> poolList;
    public UnityEvent StartEvent, poolEvent;
    private WaitForSeconds wfsObj;
    public float seconds = 2f;
    private int i;
    public vector3Data vector3Data;
   
    public bool CanRun
    {
        get => canRun;
        set => canRun = value;
    }
    IEnumerator Start()
    {
        StartEvent.Invoke();
        wfsObj = new WaitForSeconds(seconds);
        //canRun = false;
        while (canRun)
        {
            yield return wfsObj;
            poolEvent.Invoke();
            poolList[i].position = vector3Data.value;
            poolList[i].gameObject.SetActive(true);
            i++;
            if (i > poolList.Count-1)
            {
                i = 0;
            }
        }
        
    }
}
