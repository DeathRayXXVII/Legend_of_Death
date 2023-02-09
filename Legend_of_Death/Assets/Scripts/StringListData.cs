using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StringListData : ScriptableObject
{
    public List<string> value;

    public string currentValue;
    
    public void UseNextValue()
    {
        currentValue = value[0];
    }
}
