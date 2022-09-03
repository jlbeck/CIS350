/*
 * Josh Beck
 * Challenge 1
 * Manages score and win/loss conditions as well as allowing restart on game over
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //If the game is not over, display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        //win condition: 5 or more points
        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You win!\nPress R to try again!";
            }
            else
            {
                textbox.text = "You lose!\nPress R to try again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
