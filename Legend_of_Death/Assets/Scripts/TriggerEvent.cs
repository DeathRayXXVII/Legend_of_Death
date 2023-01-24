using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerColorEvent;
    public LayerMask coin;
    public LayerMask player;

    private void OnTriggerEnter(Collider col)
    {
        if (coin == LayerMask.NameToLayer("Coin"))
        {
            Debug.Log("You have entered");
            
        }
        if (LayerMask.NameToLayer("Player") == player)
        {
            
        }
        triggerEnterEvent.Invoke();
        triggerColorEvent.Invoke();
    }
}
