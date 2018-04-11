using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rodarRandomMenu : MonoBehaviour {

    // Use this for initialization
    public float X;
    public float Y;
    public float Z;
    void Start () {
        X = Random.Range(-2.0f, 2.0f);
        Y = Random.Range(-2.0f, 2.0f);
        Z = Random.Range(-2.0f, 2.0f);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(X, Y, Z);
		
	}
}
