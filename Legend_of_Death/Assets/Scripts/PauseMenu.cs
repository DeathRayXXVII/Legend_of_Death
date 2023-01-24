using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    public bool gameIsPaused;
    public float seconds;
    public UnityEvent startEvent, resumeEvent;

    public bool GameIsPaused
    {
        get => gameIsPaused;
        set => gameIsPaused = value;
    }
    private void Start()
    {
        startEvent.Invoke();
    }

    public void StartResume()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void StartPause()
    {
        GameIsPaused = true;
        Time.timeScale = 0f;
    }

}
