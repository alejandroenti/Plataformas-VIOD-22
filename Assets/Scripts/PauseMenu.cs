using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public bool isPaused
    {
        get;
        private set;
    }

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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (isPaused)
            {
                Time.timeScale = 1;
            } 
            else
            {
                Time.timeScale = 0;
            }

            isPaused = !isPaused;
        }
    }

    public void Resume()
    {
        Time.timeScale = 1;
        isPaused = false;
    }

    public void MainMenu()
    {
        // TO DO
        Debug.Log("going to Main Menu");
    }
}
