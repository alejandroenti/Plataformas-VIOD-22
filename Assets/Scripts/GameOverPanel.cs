using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{

    public bool hasWin
    {
        get;
        private set;
    }

    public GameObject gameOverPanel;

    public static GameOverPanel instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        hasWin = false;
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.levelPassed)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }

    public void PlayAgain()
    {
        Time.timeScale = 1;
        GameManager.instance.lifes = 1;
        SceneManager.LoadScene("Gym", LoadSceneMode.Single);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
