using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EntrarEstacionConLlave : MonoBehaviour
{
    SpriteRenderer sr;
    public Sprite puertaAbierta;
    public Sprite puertaCerrada;

    public string DondeEstamos;

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
    GameManager.Instance.DeDondeViene = DondeEstamos;
    SceneManager.LoadScene("2.3_MAPA2_sinNPC2");

    }
}

