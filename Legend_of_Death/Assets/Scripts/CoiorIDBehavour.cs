using UnityEngine;

public class CoiorIDBehavour : IDContanerBehavour
{
    public ColorIDDataList colorIDDataListObj;

    public void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
