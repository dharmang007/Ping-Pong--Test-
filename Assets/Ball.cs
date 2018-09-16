using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // Use this for initialization

    public float speed =5f;
	void Start ()
    {
     
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed * sx, speed * sy);

	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.position.x, transform.position.y));    
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("DeathZone1") ||
            collision.gameObject.tag.Equals("DeathZone2"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
