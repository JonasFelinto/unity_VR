using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//classe que cria os inimigos
public class nascerInimigos : MonoBehaviour {

    // Use this for initialization
    public List<GameObject> inimigosLista = new List<GameObject>(); // lista de inimigos na cena
    public GameObject inimigoPrefab;
    public int indiceInimigos; 
    void Start () {
        indiceInimigos = 0;

    }

    // Update is called once per frame
    private float tempo=3;
    //nasce inimigos em tempo random e quantidade random
	void FixedUpdate () {
        tempo = tempo - Time.deltaTime;
		if(tempo<0)
        {
            tempo = Random.Range(0.3f,2.0f);
            nascer(Random.Range(1,3));
        }
	}
    void nascer(int quantidade)
    {
        for (int i = 0; i < quantidade; i++)
        {
            setIndice();
            // caso nao exista inimigos na cena eh criado um
            if (inimigosLista.Count <= indiceInimigos) 
            {
                inimigosLista.Add(GameObject.Instantiate(inimigoPrefab, transform.position, transform.rotation));
            }
            // coloca o obstaculo/inimigo na posição correta em Z e aleatorio em X e ativa o obstaculo
            inimigosLista[indiceInimigos].transform.position = new Vector3(Random.Range(-3, 4),0.5f, 50);
            inimigosLista[indiceInimigos].SetActive(true);
        }

    }
    //função que procura inimigos que ja foram desativados na cena para não precisar instanciar outros.
    void setIndice()
    {
        indiceInimigos = 0;
        for (indiceInimigos = 0; indiceInimigos < inimigosLista.Count; indiceInimigos++)
        {
            if(inimigosLista[indiceInimigos].activeSelf == false)
            {
                break;
            }
        }
    }
}
