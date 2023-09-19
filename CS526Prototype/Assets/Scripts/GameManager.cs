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
    public bool isOver = false;
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
            SceneManager.LoadScene("ObstacleLevel");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("4thLevelScene");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }

    public void Die()
    {
        isOver = true;
        ShowGameOver();
    }

    public void Win()
    {
        isOver = true;
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
}
