using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale= 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        Time.timeScale=0f;
        pauseMenuUI.SetActive(true);
        
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        var time= Time.timeScale;
        time = 1f;
        SceneManager.LoadScene("Menu1");
    }

    public void QuitGame()
    {
        Debug.Log("Saliendo del juego ...");
        Application.Quit();
    }
}
