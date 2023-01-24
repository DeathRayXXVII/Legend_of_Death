using UnityEngine;
using UnityEngine.Events;

public class gameActionHandler : MonoBehaviour
{
    public gameAction gameActionObj;
    public UnityEvent onRaiseEvnet;

    private void Start()
    {
        gameActionObj.raise += Raise;
    }

    private void Raise()
    {
        onRaiseEvnet.Invoke();
    }
}
