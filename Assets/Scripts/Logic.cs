using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public int score = 0;
    public Text scoreDisplay;
    public Text highScoreDisplay;
    private float timer = 0;
    private int highscore;
    public GameObject gameOverScene;
    public Text highScoreIndicator;
    public bool over = false;

    // Start is called before the first frame update
    void Start()
    {
        over = false;
        try
        {
            highscore = PlayerPrefs.GetInt("highScore");
        }
        catch (System.Exception)
        {
            highscore = 0;
            PlayerPrefs.SetInt("highScore", highscore);
            throw;
        }
        highScoreDisplay.text = "HI " + highscore.ToString("D6");
    }

    // Update is called once per frame
    void Update()
    {
        if (!over)
        {
            if (timer < 0.02)
            {
                timer += Time.deltaTime;
            }
            else
            {
                score += 1;
                scoreDisplay.text = score.ToString("D6");
                timer = 0;
            }
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        if (!over) 
        { 
            gameOverScene.SetActive(true);
            highScoreIndicator.gameObject.SetActive(false);
            if (score > highscore)
            {
                highscore = score;
                highScoreDisplay.text = "HI " + highscore.ToString("D6");
                PlayerPrefs.SetInt("highScore", highscore);
                highScoreIndicator.gameObject.SetActive(true);
            }
            over = true;
        }
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
