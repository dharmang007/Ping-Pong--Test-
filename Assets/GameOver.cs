using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject ball;
    public Text title;
    public int cnt=6;
    
    void Start()
    {
        gameOverText.GetComponentsInChildren<Text>(true)[0].text = "Ping Pong";
        ball.SetActive(false);
        gameOverText.SetActive(true);        
    }

    public void SetGameOverScreen()
    {
        gameOverText.SetActive(true);
        gameOverText.GetComponentsInChildren<Text>(true)[0].gameObject.SetActive(true);
        gameOverText.GetComponentsInChildren<Text>(true)[0].text = "Game Over";
        ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        gameOverText.GetComponentsInChildren<Text>(true)[1].gameObject.SetActive(true);
        gameOverText.GetComponentsInChildren<Text>(true)[2].gameObject.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator CountDown()
    {
        while(cnt>0)
        {
            gameOverText.GetComponentsInChildren<Text>(true)[0].text = cnt.ToString();
            cnt--;
            yield return new WaitForSeconds(1);
        }
    }

    public void PlayAgain()
    {        

        gameOverText.SetActive(false);       
        ball.GetComponent<Ball>().StartGame();
        ball.SetActive(true);
        
 
    }
}