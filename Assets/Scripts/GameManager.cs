using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timeLeft = 25;

    bool gameOver = false;
    bool win = false;

    public GameObject winText;
    public GameObject gameOverText;
    public GameObject ball;
    public PlayerController player;
    public TextMeshProUGUI timerText;

    public GameObject timeText;

    public int currentScene;
    public int nextScene;

    [Header("Sound Effects")]
    public AudioClip winSound;
    public AudioClip gameOverSound;
    private AudioSource audioSource;
    [SerializeField] private AudioClip clickSound;

    void Start()
    {
        // Get or add an AudioSource on this GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
        if (timeLeft >= 0 && !win)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = timeLeft.ToString("F1");
        }
        if (timeLeft <= 0 && !win && !gameOver)
        {
            GameOver();
        }
    }
    private void PlayClick()
    {
        if (clickSound != null)
            AudioSource.PlayClipAtPoint(clickSound, Camera.main.transform.position);
    }
    private IEnumerator LoadWithDelay(int sceneIndex)
    {
        yield return new WaitForSeconds(0.15f); // wait for click sound
        SceneManager.LoadScene(sceneIndex);
    }

    public void WinGame()
    {
        win = true;
        winText.SetActive(true);
        player.enabled = false;
        ball.SetActive(false);

        // Play win sound when win text becomes active
        if (winSound != null)
            audioSource.PlayOneShot(winSound);
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverText.SetActive(true);
        player.enabled = false;
        ball.SetActive(false);

        // Play game over sound when game over text becomes active
        if (gameOverSound != null)
            audioSource.PlayOneShot(gameOverSound);
    }

    public void TimeText()
    {
        timeText.SetActive(false);
    }

    public void RestartGame()
    {
        PlayClick();
        StartCoroutine(LoadWithDelay(currentScene));
        //SceneManager.LoadScene(currentScene);
    }
    public void NextLevel()
    {
        PlayClick();
        StartCoroutine(LoadWithDelay(nextScene));
        //SceneManager.LoadScene(nextScene);
    }
    public void Back()
    {
        PlayClick();
        StartCoroutine(LoadWithDelay(0));
    }
    public void LevelMenu()
    {
        PlayClick();
        StartCoroutine(LoadWithDelay(1));
    }
}