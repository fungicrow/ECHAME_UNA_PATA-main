using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManagerSegis : MonoBehaviour

   {
     
    [SerializeField] private float typingSpeed = 0.05f;

    [SerializeField] private bool SegisHablaPrimero;

    [Header("Dialogo Texto")]
    [SerializeField] private TextMeshProUGUI segisDialogoTexto;
    [SerializeField] private TextMeshProUGUI armandaDialogoTexto;

    [Header("Botones Continuar")]
    [SerializeField] private GameObject segisBotonContinuar;
    [SerializeField] private GameObject armandaBotonContinuar;
    [Header("Animation Controllers")]
    [SerializeField] private Animator SegisBurbujaAnimator;
    [SerializeField] private Animator ArmandaBurbujaAnimator;



    [Header("Frases Dialogo")]
    [TextArea]
    [SerializeField] private string[] segisDialogoFrases;
    [TextArea]
    [SerializeField] private string[] armandaDialogoFrases;

    
    private bool dialogoEmpezado;
    private int segisIndex;
    private int armandaIndex;
    public SpriteRenderer spriteExclamacion;

    private float delayBurbujaAnimación = 0.8f;

  
    

   

    public void TriggerDialogue(){

        StartCoroutine(EmpezarDialogo());
    
    }

    private void Update(){
        if (segisBotonContinuar.activeSelf){
            if(Input.GetKeyDown(KeyCode.Space)){
                TriggerArmandaDialogo();
            }
        }

        if (armandaBotonContinuar.activeSelf){
            if(Input.GetKeyDown(KeyCode.Space)){
                TriggerSegisDialogo();
            }
        }
    }

    public IEnumerator EmpezarDialogo(){
        
        if(SegisHablaPrimero){
            SegisBurbujaAnimator.SetTrigger("Abrir");
            yield return new WaitForSeconds(delayBurbujaAnimación);
            StartCoroutine(EscribeDialogoSegis());
        }else{
            ArmandaBurbujaAnimator.SetTrigger("Abrir");

            StartCoroutine(EscribeDialogoArmanda());
             yield return new WaitForSeconds(delayBurbujaAnimación);
        }
    }

    private IEnumerator EscribeDialogoSegis(){
        foreach (char letter in segisDialogoFrases[segisIndex].ToCharArray()){
            segisDialogoTexto.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            segisBotonContinuar.SetActive(true);
        }

        
    }

    private IEnumerator EscribeDialogoArmanda(){
        foreach (char letter in armandaDialogoFrases[armandaIndex].ToCharArray()){
            armandaDialogoTexto.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            armandaBotonContinuar.SetActive(true);
        }

       
    }

    private IEnumerator ContinuarDialogoSegis(){
        armandaDialogoTexto.text = string.Empty;

        ArmandaBurbujaAnimator.SetTrigger("Cerrar");
        yield return new WaitForSeconds(delayBurbujaAnimación);

        segisDialogoTexto.text = string.Empty;
        SegisBurbujaAnimator.SetTrigger("Abrir");
        yield return new WaitForSeconds(delayBurbujaAnimación);
         
        armandaBotonContinuar.SetActive(false);
        if(segisIndex < segisDialogoFrases.Length -1){
           
           if(dialogoEmpezado)
                segisIndex++;
           else
                dialogoEmpezado = true;

           segisDialogoTexto.text = string.Empty;
            StartCoroutine(EscribeDialogoSegis());
        }
    }

   private IEnumerator ContinuarDialogoArmanda(){

        segisDialogoTexto.text = string.Empty;
       SegisBurbujaAnimator.SetTrigger("Cerrar");
        yield return new WaitForSeconds(delayBurbujaAnimación);

        armandaDialogoTexto.text = string.Empty;
        ArmandaBurbujaAnimator.SetTrigger("Abrir");
        yield return new WaitForSeconds(delayBurbujaAnimación);

        segisBotonContinuar.SetActive(false);
        if(armandaIndex < armandaDialogoFrases.Length -1){
            if(dialogoEmpezado)
            armandaIndex++;
            else
                dialogoEmpezado = true;

            armandaDialogoTexto.text = string.Empty;
            StartCoroutine(EscribeDialogoArmanda());
        }
    }

    public void TriggerSegisDialogo(){

         armandaBotonContinuar.SetActive(true);

        if(segisIndex >= segisDialogoFrases.Length - 1){
            armandaDialogoTexto.text = string.Empty;
            ArmandaBurbujaAnimator.SetTrigger("Cerrar");
        }else{
            
        StartCoroutine( ContinuarDialogoSegis());}

        
    }

    
    public void TriggerArmandaDialogo(){

        segisBotonContinuar.SetActive(true);

         if(armandaIndex >= armandaDialogoFrases.Length - 1){
           segisDialogoTexto.text = string.Empty;
           SegisBurbujaAnimator.SetTrigger("Cerrar");
          
           
        }else{
            
        StartCoroutine(ContinuarDialogoArmanda());}
    }
   }