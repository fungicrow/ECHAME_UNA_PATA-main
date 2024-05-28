using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class minijuegoArmanda : MonoBehaviour
{
    //CORUTINE
    
    
    //FASE 1 ARMANDA
    GameObject panel_buenos;
    GameObject panel_dias;
    GameObject panel_correcto_1;

    //FASE 2 MONOLO
    GameObject panel_hola;
    GameObject panel_puedo;
    GameObject panel_ayudar;
    GameObject panel_correcto_2;

    //FASE 3 ARMANDA
    GameObject panel_busco;
    GameObject panel_llave;
    GameObject panel_rampa;
    GameObject panel_correcto_3;

    //FASE 4 MONOLO
    GameObject panel_de_acuerdo;
    GameObject panel_correcto_4;

    //FASE 5 ARMANDA
    GameObject panel_gracias;
    GameObject panel_correcto_5;

    //FINAL
    GameObject panel_final;

    //ANIMACIONES

    GameObject animacion_armanda_1;
    GameObject animacion_monolo_1;
    GameObject animacion_armanda_2;
    GameObject animacion_monolo_2;
    GameObject animacion_armanda_3;

    


    // Start is called before the first frame update
    void Start()
    {
        //FASE 1 ARMANDA
        panel_buenos = GameObject.Find("panel_1");

        panel_dias = GameObject.Find("panel_1_2");
        panel_dias.SetActive(false);

        panel_correcto_1 = GameObject.Find("panel_1_3");
        panel_correcto_1.SetActive(false);

        //FASE 2 MONOLO

        panel_hola = GameObject.Find("panel_2");
        panel_hola.SetActive(false);

        panel_puedo = GameObject.Find("panel_2_2");
        panel_puedo.SetActive(false);

        panel_ayudar = GameObject.Find("panel_2_3");
        panel_ayudar.SetActive(false);

        panel_correcto_2 = GameObject.Find("panel_2_4");
        panel_correcto_2.SetActive(false);

        //FASE 3 ARMANDA

        panel_busco = GameObject.Find("panel_3");
        panel_busco.SetActive(false);

        panel_llave = GameObject.Find("panel_3_1");
        panel_llave.SetActive(false);

        panel_rampa = GameObject.Find("panel_3_2");
        panel_rampa.SetActive(false);

        panel_correcto_3 = GameObject.Find("panel_3_3");
        panel_correcto_3.SetActive(false);

        //FASE 4 MONOLO

        panel_de_acuerdo = GameObject.Find("panel_4");
        panel_de_acuerdo.SetActive(false);

        panel_correcto_4 = GameObject.Find("panel_4_1");
        panel_correcto_4.SetActive(false);

        //FASE 5 ARMANDA

        panel_gracias = GameObject.Find("panel_5");
        panel_gracias.SetActive(false);

        panel_correcto_5 = GameObject.Find("panel_5_1");
        panel_correcto_5.SetActive(false);

        //PANEL FINAL

        panel_final = GameObject.Find("panel_final");
        panel_final.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //BOTONES REPLAY
        public void Replay1(){
        GameObject.Find("armanda1").GetComponent<Animator>().Play(0,0,0);
        }

        public void Replay2(){
        GameObject.Find("monolo1").GetComponent<Animator>().Play(0,0,0);
        }

        public void Replay3(){
        GameObject.Find("armanda2").GetComponent<Animator>().Play(0,0,0);
        }

        public void Replay4(){
        GameObject.Find("monolo2").GetComponent<Animator>().Play(0,0,0);
        }

        public void Replay5(){
        GameObject.Find("armanda3").GetComponent<Animator>().Play(0,0,0);
        }



    //FASE 1 ARMANDA
    public void incorrectoFase1(){
        panel_buenos.SetActive(true);
        panel_dias.SetActive(false);
    }
    public void nubeBuenos(){
        panel_buenos.SetActive(false);
        panel_dias.SetActive(true);
        
    }

    public void nubeDias(){
        panel_dias.SetActive(false);
        panel_correcto_1.SetActive(true);
        StartCoroutine(WaitCorutine1(2f));
    }

    public void Correcto1(){
        StartCoroutine(WaitCorutine1(2f));
    }

    //FASE 2 MONOLO

    public void incorrectoFase2(){
        panel_hola.SetActive(true);
        panel_puedo.SetActive(false);
        panel_ayudar.SetActive(false);
    }

    public void nubeHola(){
        panel_hola.SetActive(false);
        panel_puedo.SetActive(true);
        
    }
    
    public void nubePuedo(){
        panel_puedo.SetActive(false);
        panel_ayudar.SetActive(true);
    }

    public void nubeAyudar(){
        panel_ayudar.SetActive(false);
        panel_correcto_2.SetActive(true);
        StartCoroutine(WaitCorutine2(2f));

    }
    public void Correcto2(){
        StartCoroutine(WaitCorutine2(2f));
    }

    //FASE 3 ARMANDA

    public void incorrectoFase3(){
        panel_busco.SetActive(true);
        panel_llave.SetActive(false);
        panel_rampa.SetActive(false);
    }

    public void nubeBusco(){
        panel_busco.SetActive(false);
        panel_llave.SetActive(true);
    }

    public void nubeLlave(){
        panel_llave.SetActive(false);
        panel_rampa.SetActive(true);
    }

    public void nubeRampa(){
        panel_rampa.SetActive(false);
        panel_correcto_3.SetActive(true);
        StartCoroutine(WaitCorutine3(2f));
    }
     public void Correcto3(){
        StartCoroutine(WaitCorutine3(2f));
    }

    //FASE 4 MONOLO

    public void incorrectoFase4(){
        panel_de_acuerdo.SetActive(true);
        panel_gracias.SetActive(false);
    }

    public void nubeDeAcuerdo(){
        panel_de_acuerdo.SetActive(false);
        panel_correcto_4.SetActive(true);
        StartCoroutine(WaitCorutine4(2f));
    }

     public void Correcto4(){
        StartCoroutine(WaitCorutine4(2f));
    }

    //FASE 5 ARMANDA

    public void incorrectoFase5(){
        panel_gracias.SetActive(true);
    }

    public void nubeGracias(){
        panel_gracias.SetActive(false);
        panel_correcto_5.SetActive(true);
        StartCoroutine(WaitCorutine5(2f));
    }
    public void Correcto5(){
        StartCoroutine(WaitCorutine5(2f));
        
    }

    //CORUTINE 
    public IEnumerator WaitCorutine1(float time){
        yield return new WaitForSeconds(time);
        panel_correcto_1.SetActive(false);
        panel_hola.SetActive(true);
        
    } 
    public IEnumerator WaitCorutine2(float time){
        yield return new WaitForSeconds(time);
        panel_correcto_2.SetActive(false);
        panel_busco.SetActive(true);
        
    } 
    public IEnumerator WaitCorutine3(float time){
        yield return new WaitForSeconds(time);
        panel_correcto_3.SetActive(false);
        panel_de_acuerdo.SetActive(true);
        
    } 
    public IEnumerator WaitCorutine4(float time){
        yield return new WaitForSeconds(time);
        panel_correcto_4.SetActive(false);
        panel_gracias.SetActive(true);
        
    } 
    public IEnumerator WaitCorutine5(float time){
        yield return new WaitForSeconds(time);
        panel_correcto_5.SetActive(false);
        panel_final.SetActive(true);
        StartCoroutine(WaitCorutine6(3f));
        
        
    } 

    public IEnumerator WaitCorutine6(float time){
        yield return new WaitForSeconds(time);
        panel_final.SetActive(false);
        SceneManager.LoadScene("2.3_MAPA2_sinNPC");
    }
}
