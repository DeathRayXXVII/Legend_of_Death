using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public CharacterClass characterObj;
    public IMove moveObj;

    private void Awake()
    {
        moveObj = characterObj;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveObj.Move();
        }
    }
}
