using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// fazer com que os obstaculos fiquem piscando (deixando transparente e voltando ao normal sem parar)
public class cuboTransparente : MonoBehaviour {

    // Use this for initialization
    public Renderer rend;
    private Color cor;
    private bool trocar;
	void Start () {
        cor = rend.material.color;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if(trocar)
        {
            cor.a += Time.deltaTime;
            if (cor.a >= 1)
                trocar = !trocar;
        }
        else
        {
            cor.a -= Time.deltaTime;
            if (cor.a<=0)
                trocar = !trocar;
        }
        

        rend.material.color = cor;


    }
}
