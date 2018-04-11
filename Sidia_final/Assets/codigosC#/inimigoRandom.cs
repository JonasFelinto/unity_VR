using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//classe define qual obstaculo será criado
public class inimigoRandom : MonoBehaviour {

    // Use this for initialization
    public GameObject[] filhos;
    private int ativado;
	void OnEnable () {
        filhos[ativado].SetActive(false);
        ativado = Random.Range(0, filhos.Length);
        filhos[ativado].SetActive(true);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
