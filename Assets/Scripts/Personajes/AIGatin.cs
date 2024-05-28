using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGatin : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private float distance;
    public float multiplicadorVelocidad = 1; 
    private Animator animatorControler;

    Vector2 GatinPosition;

    Vector2 NewPosition;

    

    // Start is called before the first frame update
    void Start()
    {
        GatinPosition = new Vector2 (transform.position.x, transform.position.y + 0.05f);
        animatorControler=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;



        if(distance >= 2){
            
            
            transform.position= new Vector2 (Mathf.MoveTowards (transform.position.x, player.transform.position.x, speed*Time.deltaTime),transform.position.y);
        }
//ANIMACION
        
       if(Input.GetKeyDown(KeyCode.A))
       {
        GetComponent<Animator>();
        animatorControler.SetBool("CaminaIz", true);
       }

       if (Input.GetKeyUp(KeyCode.A)){
         animatorControler.SetBool("CaminaIz", false);
         animatorControler.SetBool("Quieto", true);
       }



       if(Input.GetKeyDown(KeyCode.D))
       {
        this.GetComponent<Animator>();
        animatorControler.SetBool("CaminaD", true);

       }
       if (Input.GetKeyUp(KeyCode.D)){
         animatorControler.SetBool("CaminaD", false);
         animatorControler.SetBool("Quieto", true);
       }
        
       
    }


    
}
