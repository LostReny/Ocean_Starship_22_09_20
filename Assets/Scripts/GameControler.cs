using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour


{
   public GameObject startPanel;
    public GameObject gameOverPanel;
    public GameObject hudPanel;

    public Button startButton;
    public Button restartButton;
    public Text scoreText;

    public GameObject ship;
    public GameObject enemies;

    private int score;

    public static GameControler instance;
void Awake()
    {
        instance = this;
        startPanel.SetActive(true);
        ship.SetActive(false);
        enemies.SetActive(false);
    }

        
    
    // Start is called before the first frame update
   void StartGame ()
    {
        startPanel.SetActive(false);
        hudPanel.SetActive(true);
        ship.SetActive(true);
        enemies.SetActive(true);
    }
    void Start()
        {
            startButton.onClick.AddListener(StartGame);
            restartButton.onClick.AddListener(Restart);
        }

    public void Score(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }


    public void GameOver ()
    {
        gameOverPanel.SetActive(true);
    }
    
    void Restart ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
