using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    // Use this for initialization
    public GameObject nave;
    public GameObject naveMesh;
    public GameObject cam;
    private Vector3 auxiliar;
    private float speed;
    private bool morto;
    void Start () {
        Application.targetFrameRate = 70;
        speed = 3;
        morto = false;

    }
    IEnumerator morreu()
    {
        yield return new WaitForSeconds(3);
        Application.LoadLevel(0);
    }
    // Update is called once per frame
    void FixedUpdate () {
        if (!morto)
        {
            inputAccelerometro();
            corrigirPosic();
        }

    }
    void inputPc()
    {
        nave.transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime* speed, 0, 0);
        cam.transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
        naveMesh.transform.localEulerAngles = new Vector3(0, -Input.GetAxis("Horizontal") * 60,0);
    }
    void inputAccelerometro()
    {
        nave.transform.Translate(Input.acceleration.x*Time.deltaTime * speed, 0, 0);
        cam.transform.Translate(Input.acceleration.x * Time.deltaTime * speed, 0, 0);
        naveMesh.transform.localEulerAngles = new Vector3(0, -Input.acceleration.x * 60, 0);
    }
    //função que não deixa o player tocar nas grades, não permite que o player "saia" da tela
    void corrigirPosic()
    {
        if (transform.position.x >3)
        {
            auxiliar = cam.transform.position;
            auxiliar.x = 3;
            cam.transform.position = auxiliar;
            auxiliar.y = 0.7f;
            auxiliar.z = -8.5f;
            nave.transform.position = auxiliar;
        }
        if (transform.position.x < -3)
        {
            auxiliar = cam.transform.position;
            auxiliar.x = -3;
            cam.transform.position = auxiliar;
            auxiliar.y = 0.7f;
            auxiliar.z = -8.5f;
            nave.transform.position = auxiliar;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        morto = true;
        StartCoroutine("morreu");
        
    }

}
