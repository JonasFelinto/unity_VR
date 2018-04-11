using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//codigo que faz os inimigos se movimentarem e ao atingir a posição -20 em Z eles somem
public class inimigoMovimento : MonoBehaviour {

	// Use this for initialization
    public float speedInimigo;
    void OnEnable() {
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(0,0, -speedInimigo*Time.deltaTime);
        if (transform.position.z < -20)
        {
            gameObject.SetActive(false);
        }
            
		
	}
}
