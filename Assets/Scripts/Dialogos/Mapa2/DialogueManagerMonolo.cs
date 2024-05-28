using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class DialogueManagerMonolo : MonoBehaviour
{  
   
    
    [SerializeField] private float typingSpeed = 0.05f;

    [SerializeField] private bool monoloHablaPrimero;

    [Header("Dialogo Texto")]
    [SerializeField] private TextMeshProUGUI monoloDialogoTexto;

    [Header("Botones Continuar")]
  
    [SerializeField] private GameObject monoloBotonContinuar;
    [Header("Animation Controllers")]

    [SerializeField] private Animator MonoloBurbujaAnimator;



    [Header("Frases Dialogo")]

    [TextArea]
    [SerializeField] private string[] monoloDialogoFrases;

    
    private bool dialogoEmpezado;

    private int monoloIndex;
    public SpriteRenderer spriteExclamacion;

    private float delayBurbujaAnimación = 0.6f;
    private float delayMinijuego = 0.2f;
    

   
 void Start(){
    
 }
    public void TriggerDialogue(){

        StartCoroutine(EmpezarDialogo());
        
    
    }

    private void Update(){
        if (monoloBotonContinuar.activeSelf){
            if(Input.GetKeyDown(KeyCode.Space)){
                TriggerArmandaMinijuego();
            }
        }
    }

    public IEnumerator EmpezarDialogo(){
        if(monoloHablaPrimero){
        MonoloBurbujaAnimator.SetTrigger("Abrir");
        yield return new WaitForSeconds(delayBurbujaAnimación);
        StartCoroutine(EscribeDialogoMonolo());}else{
            StartCoroutine(CerrarDialogoMonolo());
        }
    }

    private IEnumerator EscribeDialogoMonolo(){
        foreach (char letter in monoloDialogoFrases[monoloIndex].ToCharArray()){
            monoloDialogoTexto.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            monoloBotonContinuar.SetActive(true);
            }
    }
     private IEnumerator CerrarDialogoMonolo(){
        yield return new WaitForSeconds(delayBurbujaAnimación);
        yield return new WaitForSeconds(delayMinijuego);
        SceneManager.LoadScene("2.1_MINIJUEGO_ARMANDA");
     }

     public void TriggerArmandaMinijuego(){

         if(monoloIndex < monoloDialogoFrases.Length - 1){
            if(dialogoEmpezado){
                monoloIndex++;}
                else
                {
                    dialogoEmpezado = true;
                }
            }
            monoloDialogoTexto.text = string.Empty;
            MonoloBurbujaAnimator.SetTrigger("Cerrar");
            StartCoroutine(CerrarDialogoMonolo());
            
        }

            
        
    }