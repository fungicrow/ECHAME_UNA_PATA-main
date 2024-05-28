using UnityEngine;
using UnityEngine.Events;
 
public class TriggerDialogoScript : MonoBehaviour
{
   DialogueManager dialogueManager;

    void Start(){
        dialogueManager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Armanda"){
            dialogueManager.TriggerDialogue();
        }
        
    }}
    
