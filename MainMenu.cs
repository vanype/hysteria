using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    bool isPaused = false;
    public GameObject pausePanel;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Home) || Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Menu))
        {
            if (!isPaused)
            {
                pausePanel.gameObject.SetActive(true);
                Time.timeScale = 0f;
                isPaused = true;
            }
            else
            {
                pausePanel.gameObject.SetActive(false);
                Time.timeScale = 1f;
                isPaused = false;
            }


        }
        
    }

    public void SaveAndQuit()
    {
        SceneManager.LoadScene(0);
    }
    public void Back()
    {
        pausePanel.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
