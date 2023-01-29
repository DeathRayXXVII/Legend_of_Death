using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerColorEvent, clickEvent;
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

    void OnButtonClick()
    {
        clickEvent.Invoke();
    }
}
