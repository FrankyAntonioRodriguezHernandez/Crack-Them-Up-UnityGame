using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverPanel;
    public string nombreSiguienteEscena;

    void Start()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
            Time.timeScale =1f;
        }
    }

    public void ShowGameOverPanel()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale =0f;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(3);
        Time.timeScale =1f;
    }


}