using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu]
public class Instancers : ScriptableObject
{
   public GameObject prefab;
   private int num;
   
   public void CreatInstance()
   {
      Instantiate(prefab); //instantiate an object
   }

   public void CreateInstance(vector3Data obj)
   {
      Instantiate(prefab, obj.value, Quaternion.identity); //generate with one vector 3
   }
   
   public void CreateInstanceFromList(Vector3DataList obj)
   {
      foreach (var t in obj.vector3Dlist)
      {
         Instantiate(prefab, t.value, Quaternion.identity);
      }
   }
   
   
   public void CreateInstanceFromListCounting(Vector3DataList obj) //generate down a list like A B C D.....
   {
      Instantiate(prefab, obj.vector3Dlist[num].value, Quaternion.identity); //instantiate the object at 0
      num++; //add one
      if (num == obj.vector3Dlist.Count) //if it is equal to the count
      {
         num = 0; //setting it back to zero
      }
   }
   
   public void CreateInstanceListRandomly(Vector3DataList obj) //randomly generate from a list
   {
      num = Random.Range(0, obj.vector3Dlist.Count );// - 1
      Instantiate(prefab, obj.vector3Dlist[num].value, Quaternion.identity); //instantiate the object at 0

   }
   
}
