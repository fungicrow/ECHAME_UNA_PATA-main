using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSegis : MonoBehaviour
{
    DialogueManagerSegis dialogueManager;
     void Start(){
        
        
        dialogueManager = GameObject.Find("DialogueManagerSegis").GetComponent<DialogueManagerSegis>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Armanda"){
            dialogueManager.TriggerDialogue();
        }
        
    }}
