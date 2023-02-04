using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

[RequireComponent(typeof(Collider))]
public class TriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerColorEvent, clickEvent;
    public LayerMask coin;
    public LayerMask player;
    private Collider colliderObj;

    private void Start()
    {
        colliderObj = GetComponent<Collider>();
        colliderObj.isTrigger = true;
    }

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
