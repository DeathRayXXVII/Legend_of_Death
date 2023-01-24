using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : IDContanerBehavour
{
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayed; 
    private IEnumerator OnTriggerEnter(Collider other)
    {
        //fecting the otherID from a diffrent script
        var tempObj = other.GetComponent<IDContanerBehavour>();
        //if this is not null get the ID
        if (tempObj == null)
           yield break;
        
        var otherID = tempObj.idObj;
        //checking if the ID's are the same
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayed.Invoke();
        }
    }
}
