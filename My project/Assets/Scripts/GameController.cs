using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject pausePanel, gamePanel;
    public Text startText;
    [SerializeField]
    private Text scoreText, bestScoreText;
    public int score;

    private void Start()
    {
        score = 0;
        pausePanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu")

    }
    private void SwitchToPause()
    { 
        pausePanel.SetActive(!pausePanel.activateSelf);
        gamePanel.SetActive(!gamePanel.activateSelf);
        switch
    }

}
