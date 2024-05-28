using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cartel : MonoBehaviour
{

    GameObject PopUp;

    [SerializeField] private Animator AnimacionCartel;
    // Start is called before the first frame update
    void Start()
    {
        
       PopUp = GameObject.Find("cartel_grande_edit");
       PopUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetMouseButtonDown(0)){
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            if(hit.collider != null)
            {
                Debug.Log ("Target Position: " + hit.collider.gameObject.name);
            }
        }
        */




    }
   
   void OnMouseDown(){
        PopUp.SetActive(true);
   
   }

   void OnTriggerEnter2D(Collider2D other){
    if(other.gameObject.tag == "Armanda"){
            AnimacionCartel.SetTrigger("Abrir");
    }
   }

   void OnTriggerExit2D(Collider2D other){
    if(other.gameObject.tag == "Armanda"){
            AnimacionCartel.SetTrigger("Cerrar");
    }
   }
}
