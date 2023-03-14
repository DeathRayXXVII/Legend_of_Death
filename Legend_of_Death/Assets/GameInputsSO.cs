using System;
using UnityEngine;

[CreateAssetMenu]
public class GameInputsSO : ScriptableObject
{
    public GameInputs inputs;

    private void OnEnable()
    {
        inputs = new GameInputs();
    }
}
