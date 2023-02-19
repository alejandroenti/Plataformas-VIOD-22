using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPanel : MonoBehaviour
{

    public bool hasDead
    {
        get;
        private set;
    }

    public GameObject deathPanel;

    public static DeathPanel instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        hasDead = false;
        deathPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.lifes <= 0)
        {
            Time.timeScale = 0;
            deathPanel.SetActive(true);
        }
    }

    public void PlayAgain()
    {
        GameManager.instance.lifes = 1;
        Time.timeScale = 1;
        SceneManager.LoadScene("Gym", LoadSceneMode.Single);
    }

    public void MainMenu()
    {
        GameManager.instance.lifes = 1;
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
