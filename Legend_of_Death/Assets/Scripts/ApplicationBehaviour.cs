using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationBehaviour : MonoBehaviour
{
    public int sceneToLoad;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
        Time.timeScale = 1f;
    }
    
}
