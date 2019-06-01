using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

    // Use this for initialization
    private AudioSource hitSound;
    public GameObject gameManager;
    //public GameObject weed;
    public float speed =4f;
    	
	// Update is called once per frame
	void Update ()
    {

    }

    public void StartGame()
    {
        //this.Start();
        gameObject.SetActive(true);
        gameObject.transform.position = new Vector2(0f,0f);
        hitSound = GetComponent<AudioSource>();
        float sx = UnityEngine.Random.Range(0, 1) < 0.5 ? -80f : 80f;
        float sy = UnityEngine.Random.Range(0, 1) < 0.5 ? -10f : 10f;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(sx, sy));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("DeathZone1") ||
            collision.gameObject.tag.Equals("DeathZone2"))
        {   
            gameManager.GetComponent<GameOver>().SetGameOverScreen();
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            this.GetComponent<Rigidbody2D>().angularVelocity = 0f;

        }
        else if(collision.gameObject.tag.Equals("Player1") || collision.gameObject.tag.Equals("Player2"))
        {
            hitSound.Play();
        }

    }
}
