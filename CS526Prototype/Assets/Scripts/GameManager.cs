using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public string nextLevelName;
    private static GameManager _instance;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI gameWinText;
    public TextMeshProUGUI outOfBulletsText;
    public bool isOver = false;
    private bool isWon = false;
    private float timer = 2.0f;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("GameManager is null!");
            }
            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
        HideGameOver();
        HideGameWin();
        HideNoBullets();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("TutorialLevel");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("WallsLevel");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("PreObstacleLevel");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("ObstacleLevel");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("4thLevelScene");
        }
        if (Input.GetKeyDown(KeyCode.F) && isWon)
        {
            SceneManager.LoadScene(nextLevelName);
        }

        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            if (outOfBulletsText.gameObject.activeSelf)
            {
                HideNoBullets();
            }
        }
    }

    public void Die()
    {
        if (isOver)
            return;
        isOver = true;
        ShowGameOver();
    }

    public void Win()
    {
        if (isOver)
            return;
        isOver = true;
        isWon = true;
        ShowGameWin();
    }
    
    private void HideGameOver()
    {
        gameOverText.gameObject.SetActive(false);
    }

    private void ShowGameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
    private void HideGameWin()
    {
        gameWinText.gameObject.SetActive(false);
    }

    private void ShowGameWin()
    {
        gameWinText.gameObject.SetActive(true);
    }
    
    private void HideNoBullets()
    {
        outOfBulletsText.gameObject.SetActive(false);
    }
    public void ShowNoBullets()
    {
        outOfBulletsText.gameObject.SetActive(true);
        timer = 2.0f;
    }
}
