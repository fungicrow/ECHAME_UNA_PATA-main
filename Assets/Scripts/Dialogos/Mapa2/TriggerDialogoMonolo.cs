using UnityEngine;
using UnityEngine.Events;
 
public class TriggerDialogoMonolo : MonoBehaviour
{
   DialogueManagerMonolo dialogueManager;

    void Start(){
        
        dialogueManager = GameObject.Find("DialogueManagerMonolo").GetComponent<DialogueManagerMonolo>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Armanda"){
            dialogueManager.TriggerDialogue();
        }
        
    }}
    

