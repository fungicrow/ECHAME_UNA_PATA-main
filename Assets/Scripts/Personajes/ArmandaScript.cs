using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmandaScript : MonoBehaviour
{
     public float multiplicadorVelocidad = 1;

     public Animator animatorControler;
    
     //SPAWN

     public GameObject spawn;
     
    //AUDIO PASOS 
     public AudioSource pasos;
     private bool Activo;
      public bool canMove = true;

    

    // Esto es para los dialogos
    

    void Start()
    {
        animatorControler=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //MOVIMIENTO
       if(canMove){
        float mov = Input.GetAxis("Horizontal") * multiplicadorVelocidad * Time.deltaTime;

        float movAnim = Input.GetAxisRaw("Horizontal") * multiplicadorVelocidad * Time.deltaTime;
        
        
        transform.Translate(mov, 0, 0); 
        
     //animacion
        
        if(movAnim > 0){
            this.GetComponent<SpriteRenderer>().flipX=true;
            animatorControler.SetBool("activaCamina", true);
          
            
        }else if(mov < 0){
            this.GetComponent<SpriteRenderer>().flipX=false;
             animatorControler.SetBool("activaCamina", true);
             
        }

        if(movAnim == 0){
              animatorControler.SetBool("activaCamina", false);
        }

           //AUDIO PASOS
           if(Input.GetButtonDown("Horizontal")){
           
           if(Activo==false) {
            pasos.Play();//intento pasos
           }
        }else if (Input.GetButtonUp("Horizontal")){
            if(Activo==false){
                pasos.Pause();
            }
        }}
    }}
    

