using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager2 : MonoBehaviour
{
    [SerializeField] private float typingSpeed = 0.05f;


     [Header("Dialogo Texto")]
    [SerializeField] private TextMeshProUGUI armandaDialogoTextoPensar;

    [Header("Botones Continuar")]
    [SerializeField] private GameObject armandaPensarBotonContinuar;

    [Header("Animation Controllers")]
    [SerializeField] private Animator ArmandaPensarBurbujaAnimator;

    [Header("Frases Dialogo")]
    [TextArea]
    [SerializeField] private string[] armandaPensarDialogoFrases;

    private bool dialogoEmpezado;
    private int armandaIndex;

    private float delayBurbujaAnimación = 0.6f;


public IEnumerator EmpezarDialogoPensar(){
        ArmandaPensarBurbujaAnimator.SetTrigger("Abrir");
    

            yield return new WaitForSeconds(delayBurbujaAnimación);
            StartCoroutine(EscribeDialogoPensar());
}


public IEnumerator EscribeDialogoPensar(){
    foreach (char letter in armandaPensarDialogoFrases[armandaIndex].ToCharArray()){
            armandaDialogoTextoPensar.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            armandaPensarBotonContinuar.SetActive(true);
        }
}
private IEnumerator CerrarDialogoPensar(){
    armandaDialogoTextoPensar.text = string.Empty;
        ArmandaPensarBurbujaAnimator.SetTrigger("Cerrar");
        yield return new WaitForSeconds(delayBurbujaAnimación);
         if(armandaIndex < armandaPensarDialogoFrases.Length -1){
           
           if(dialogoEmpezado)
                armandaIndex++;
           else
                dialogoEmpezado = true;

            armandaDialogoTextoPensar.text = string.Empty;

        }
}
void OnTriggerEnter2D (Collider2D other) { 
    if (other.tag == "Armanda"){
         ArmandaPensarBurbujaAnimator.SetTrigger("Abrir");
        StartCoroutine(EmpezarDialogoPensar());
    }else {
        StartCoroutine(CerrarDialogoPensar());
    }
}
public void TriggerArmandaDialogo(){

        

        if(armandaIndex >= armandaPensarDialogoFrases.Length - 1){
           
            ArmandaPensarBurbujaAnimator.SetTrigger("Cerrar");
          
        }else{
            
        StartCoroutine( CerrarDialogoPensar());}


}}
