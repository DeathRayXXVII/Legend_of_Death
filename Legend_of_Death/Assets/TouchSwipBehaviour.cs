using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class TouchSwipBehaviour : MonoBehaviour
{
    public GameInputsSO game;

    private void Awake()
    {
        game.inputs.Touch.PrimaryContact.started += StartTouch;
    }

    private void StartTouch(InputAction.CallbackContext ctx)
    {
        Debug.Log("Touch Down");
    }

    private void OnEnable()
    {
        game.inputs.Enable();
    }

    private void OnDisable()
    {
        game.inputs.Disable();
    }
}
