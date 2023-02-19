using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public bool isPaused
    {
        get;
        private set;
    }

    public GameObject pauseMenu;

    // SINGLETON
    public static PauseMenu instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (isPaused)
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
            } 
            else
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            }

            isPaused = !isPaused;
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        isPaused = false;
        pauseMenu.SetActive(false);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
