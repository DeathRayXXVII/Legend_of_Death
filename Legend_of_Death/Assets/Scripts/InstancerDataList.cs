using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InstancerDataList : ScriptableObject
{
    public GameObject[] prefabList;
    public int num;
    public int num2;
    
    public void CreateInstanceListRandomly(Vector3DataList obj) //randomly generate from a list
    {
        num2 = Random.Range(0, obj.vector3Dlist.Count);// - 1
        num = Random.Range(0, prefabList.Length);// - 1
        Instantiate(prefabList[num], obj.vector3Dlist[num2].value, Quaternion.identity); //instantiate the object at 0

    }
}
