using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public static float score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public static float lives = 2f;
    public static bool enemyDestroyed = false;
    public AudioSource audioSource;
    public AudioClip explosionClip;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverText.gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();

        if(lives == 0f)
        {
            audioSource.PlayOneShot(explosionClip);
            GameOver();
        }

        if(enemyDestroyed == true)
        {
            audioSource.PlayOneShot(explosionClip);
            enemyDestroyed = false;
        }

    }

    
}
