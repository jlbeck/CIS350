/*
 * Josh Beck
 * Prototype 4
 * Implements a game manager object as a singleton
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public int score;
    public DisplayText gameText;

    //variable to keep track of current level
    private string CurrentLevelName = string.Empty;

    #region This code makes this class a Singleton
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //this makes the GameManager GameObject persist across scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to instantiate a seocnd instance of singleton Game manager");
        }
    }
    #endregion

    private void Start()
    {
        gameText.beforeStart = true;
        Time.timeScale = 0f;
    }

    private void StartGame()
    {
        gameText.beforeStart = false;
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (gameText.beforeStart && Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }



}
