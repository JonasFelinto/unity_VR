using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//classe que movimenta os planos(com as arvores e cercas) no jogo.
public class movimentarObjetos : MonoBehaviour {

    // Use this for initialization
    public float speed;
    public GameObject[] planos;
    private int indice;
    public bool podAndar;

    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (podAndar)
        {
            for (indice = 0; indice < planos.Length; indice++)
            {
                planos[indice].transform.Translate(0, 0, -speed * Time.deltaTime);
                if (planos[indice].transform.position.z < -20)
                {
                    if (indice == 0)
                    {
                        planos[indice].transform.position = new Vector3(0, 0, planos[planos.Length - 1].transform.position.z + 20 -speed*Time.deltaTime);
                    }
                    else
                    {
                        planos[indice].transform.position = new Vector3(0, 0, planos[indice - 1].transform.position.z + 20);
                    }

                }
            }
        }
	}
}
