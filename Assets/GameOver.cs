using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverText;
    
    public void SetGameOverScreen()
    {
        gameOverText.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void PlayAgain()
    {
        gameOverText.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
