using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatDataBehaviour : MonoBehaviour
{
   public float value;
   public floatData floatDataObj;

   public void UpdateValue(floatData obj)
   {
      value += obj.value;
   }
   public void UpdateFloatData(float number)
   {
      floatDataObj.UpdateValue(number);
   }

   private void OnTriggerEnter(Collider other)
   {
      var newObj = other.GetComponent<FloatDataContainer>().DataObj;
      UpdateValue(newObj);
   }
}
