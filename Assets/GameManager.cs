using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public TMP_Text scoreText;

    public GameObject GameOverScreen;
    
    void Start()
    {
        instance = this;
        Time.timeScale = 1;
        GameOverScreen.SetActive(false);
    }

    void Update()
    {
        scoreText.text = score.ToString();

    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void replay()
    {
        SceneManager.LoadScene(0);
    }
}
