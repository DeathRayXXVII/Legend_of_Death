using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class gameAction : ScriptableObject
{
    public UnityAction raise;

    public void RaiseAction()
    {
        raise.Invoke();
    }
}
