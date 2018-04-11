using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//esta classe esta encarregada de carregar a cena principal do jogo ou de sair do jogo
public class menuOlharSelecionar : MonoBehaviour {

    // Use this for initialization
    public Image temporizador1; // imagem para mostrar o carregamento enquanto o player olha para o botão de iniciar
    public bool comecou; // variavel que faz com que a função de carregar o nivel não seja chamada mais de uma vez
    private RaycastHit hit; // variavel que detecta para onde o player esta olhando
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(!comecou)
        {
            
            Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
            if (Physics.Raycast(ray, out hit))
            {
                temporizador1.fillAmount += Time.deltaTime * 0.5f; // mostrar o tempo que esta faltando para carregar
                if (temporizador1.fillAmount >=1)
                {
                    comecou = false;
                    if (hit.collider.tag == "Play")
                        Application.LoadLevel(1);
                    else
                        Application.Quit();
                }
            }
            else
            {
                if (temporizador1.fillAmount != 0)
                {
                    temporizador1.fillAmount = 0;//zerar o tempo caso o player não esteja olhando para nem um botao
                }
            }
        }
        
    }
}
