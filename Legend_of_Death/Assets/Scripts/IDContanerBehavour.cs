using System;
using UnityEngine;
using UnityEngine.Events;

public class IDContanerBehavour : MonoBehaviour
{
  public ID idObj;
  public UnityEvent startEvent;

  public void Start()
  {
    startEvent.Invoke();
  }
}
