using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniuegoGatin : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject panelPrincipal;
    GameObject panelRampa1;
    GameObject panelRampa2;
    GameObject panelRampa3;

    GameObject panelSinRampa;
    void Start()
    {
        panelPrincipal = GameObject.Find("gatin_inicio");
        panelPrincipal.SetActive(true);
        
        panelRampa1 = GameObject.Find("gatin_1");
        panelRampa1.SetActive(false);

        panelRampa2 = GameObject.Find("gatin_2");
        panelRampa2.SetActive(false);

        panelRampa3 = GameObject.Find("gatin_3");
        panelRampa3.SetActive(false);

        panelSinRampa = GameObject.Find("gatin_0");
        panelSinRampa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //PRIMER PANEL
    public void AvanzaBoton1(){
        panelPrincipal.SetActive(false);
        panelRampa1.SetActive(true);
    }

    public void RetrocedeBoton1(){
        panelPrincipal.SetActive(false);
        panelRampa3.SetActive(true);
    }

    //SEGUNDO PANEL

    public void AvanzaBoton2(){
        panelRampa1.SetActive(false);
        panelRampa2.SetActive(true);
    }

     public void RetrocedeBoton2(){
        panelRampa1.SetActive(false);
        panelSinRampa.SetActive(true);
    }

    // TERCER PANEL

    public void AvanzaBoton3(){
        panelRampa2.SetActive(false);
        panelRampa3.SetActive(true);
    }

    public void RetrocedeBoton3(){
        panelRampa2.SetActive(false);
        panelRampa1.SetActive(true);

    }

    //CUARTO PANEL

    public void AvanzaBoton4(){
        panelRampa3.SetActive(false);
        panelSinRampa.SetActive(true);
    }

    public void RetrocedeBoton4(){
        panelRampa3.SetActive(false);
        panelRampa2.SetActive(true);
    }

    //QUINTO PANEL

    public void AvanzaBoton5(){
        panelSinRampa.SetActive(false);
        panelRampa1.SetActive(true);
    
    }

    public void RetrocedeBoton5(){
        panelSinRampa.SetActive(false);
        panelRampa3.SetActive(true);
    }
}

    
