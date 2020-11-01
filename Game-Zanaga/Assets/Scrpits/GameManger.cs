using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    void Awake()
    {
        if (FindObjectsOfType<GameManger>().Length > 1)
            Destroy(gameObject); 
        else DontDestroyOnLoad(gameObject);
    }
    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
