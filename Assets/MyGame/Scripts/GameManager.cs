using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private const string Scene = "MainScene";
    private const string Scene1 = "MenueScene";
    public static GameManager instance;
    public GameObject gameOverPanel;
    public Text scoreText;
    int score = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void GameOver()
    {
        ObstacleSpawner.instance.gameOver = true;
        StopScrolling();
        gameOverPanel.SetActive(true);
    }

    void StopScrolling()
    {
        TextureScroll[] scrollingObjects = FindObjectsOfType<TextureScroll>();

        foreach(TextureScroll item in scrollingObjects)
        {
            item.scroll = false;
            Debug.Log(item.name);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(Scene);
    }

    public void Menu()
    {
        SceneManager.LoadScene(Scene1);
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
