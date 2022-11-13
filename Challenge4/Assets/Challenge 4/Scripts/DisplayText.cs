/*
 * Josh Beck
 * Prototype 4
 * Displays text on startup, during game, and after game over
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayText : MonoBehaviour
{

    public Text gameText;
    public SpawnManagerX spawnManager;

    public bool beforeStart;
    public bool gameOver;
    public bool won;
    public int wavesToWin = 10;

    private void Start()
    {
        beforeStart = true;
        gameOver = false;
        won = false;
        Time.timeScale = 0f;
    }

    private void StartGame()
    {
        beforeStart = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        if (beforeStart && Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }

        if (spawnManager.waveCount > wavesToWin)
        {
            won = true;
            gameOver = true;
        }


        if (beforeStart)
        {
            gameText.text = "To win: Defeat " + wavesToWin + " waves of enemies\nTo lose: Allow all enemies through your goal\nPress spacebar to continue";
        }
        else if (gameOver)
        {

            Time.timeScale = 0f;

            if (won)
            {
                gameText.text = "You win! Press R to restart.";
            }
            else
            {
                gameText.text = "You lose! Press R to restart.";
            }

            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }
        else
        {
            gameText.text = "Current wave: " + (spawnManager.waveCount) + "/" + wavesToWin;
        }
    }
}
