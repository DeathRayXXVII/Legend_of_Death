using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/StringData")]
public class StringListData : ScriptableObject
{
    public List<string> value;

    public string currentValue;
    
    public void UseNextValue()
    {
        currentValue = value[0];
    }
}
