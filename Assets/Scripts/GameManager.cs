using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    private readonly TMP_Text scoreText;
    private readonly GameObject gameOverScreen;

    private int score = 0;
    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            if (value != score + 1) {
                Debug.LogWarning("Score can only be incremented by 1");
                return;
            }

            score = value;
        }
    }
    
    void Start()
    {
        instance = this;

        Time.timeScale = 1;
        gameOverScreen.SetActive(false);
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0F;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
