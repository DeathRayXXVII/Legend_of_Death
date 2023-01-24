using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    public intData scoreKey;
    public void QuitAplication()
    {
    #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
    #else
		    Application.Quit ();
    #endif
    }

    public void SaveData()
    {
        //PlayerPrefs.SetInt(scoreKey);
        PlayerPrefs.Save();
    }

    public void LoadData()
    {
        
    }
}
