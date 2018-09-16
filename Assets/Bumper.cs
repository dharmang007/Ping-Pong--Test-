using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour {

    public bool player1;
    public float speed = 5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player1.Equals(true))
        {
            transform.Translate(0f, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0f);
        }
        else
        {
            transform.Translate(0f, Input.GetAxisRaw("Vertical2") * speed * Time.deltaTime, 0f);
        }
    }
}
