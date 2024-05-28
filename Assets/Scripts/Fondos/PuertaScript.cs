using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaScript : MonoBehaviour
{
    SpriteRenderer sr;
    public Sprite puertaAbierta;
    public Sprite puertaCerrada;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseEnter(){
        sr.sprite = puertaAbierta; 
    }

    void OnMouseExit(){
        sr.sprite = puertaCerrada; 
    }
    void OnMouseDown(){
        SceneManager.LoadScene("2.MAPA2_1");
    }

}
