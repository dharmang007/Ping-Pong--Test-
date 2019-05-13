using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

    // Use this for initialization

    public float speed =5f;
	void Start ()
    {
     
        float sx = Random.Range(0, 1) < 0.5 ? -80f : 80f;
        float sy = Random.Range(0, 1) < 0.5 ? -10f : 10f;

        GetComponent<Rigidbody2D>().AddForce(new Vector2(sx, sy));

	}
	
	// Update is called once per frame
	void Update ()
    {
        //GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.position.x, transform.position.y));    

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("DeathZone1") ||
            collision.gameObject.tag.Equals("DeathZone2"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
