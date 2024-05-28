using UnityEngine.Events;
using UnityEngine;

public class TriggerPensar : MonoBehaviour
{
    DialogueManagerPensar dialogueManagerPensar;

    void Start(){
       dialogueManagerPensar = GameObject.Find("DialogueManagerArmandaPensar").GetComponent<DialogueManagerPensar>();
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Armanda"){
            dialogueManagerPensar.TriggerDialoguePensar();
    
        }
        
    }}

