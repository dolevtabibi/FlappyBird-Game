using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private Player player;

    private int score;

    private void Awake()
    {
        Application.targetFrameRate= 60;
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        gameOver.SetActive(false);
        playButton.SetActive(false);
        Time.timeScale = 1;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject); 
        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled= false;

    }


    public void GameOver()
    {

        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
