using System;
using System.Collections;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Events;

public class TransformBehaviours : MonoBehaviour
{
    public vector3Data location;
    public UnityEvent onEnableEvent;
    public float holdTime = 3f;
    public WaitForSeconds waitforSecondsObj;
    
    public vector3Data v3data;
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    public BoolData canRun;


    private void Awake()
    {
        waitforSecondsObj = new WaitForSeconds(holdTime);
    }

    private IEnumerator Start()
    {
        yield return waitforSecondsObj;
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        onEnableEvent.Invoke();
        StartCoroutine(Start());
    }

    public void UpdatePosition()
    {
        transform.position = location.value;
    }


    public void ResetToZero()
    {
        transform.position = Vector3.zero;
    }

    public void SetV3Value()
    {
        v3data.value = transform.position;
    }

    public void StartSendTrnasform()
    {
        canRun.value = true;
        StartCoroutine(SendTransform());
    }

    private IEnumerator SendTransform()
    {
        while (canRun.value)
        {
            SetV3Value();
            yield return new WaitForFixedUpdate();
        }
    }
}
