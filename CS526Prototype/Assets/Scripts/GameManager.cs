using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class GameManager : MonoBehaviour
{
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
