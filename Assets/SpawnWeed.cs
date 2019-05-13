using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeed : MonoBehaviour
{
    public GameObject weed;
    // Start is called before the first frame update
    void Start()
    {
        float xposition = Random.Range(-7, 7);
        Instantiate(weed,new Vector3(xposition,0f),new Quaternion(0f,0f,0f,0f));
    }

    void Update()
    {

    }
    void Create()
    {
        
    }
}
