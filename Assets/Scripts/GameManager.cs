using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public int lifes;
    public bool hasLevelKey;
    public bool levelPassed;
    public bool gameOver;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        lifes = 1;
        hasLevelKey= false;
        levelPassed = false;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
