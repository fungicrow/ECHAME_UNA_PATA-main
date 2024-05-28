using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;



public class DialogueManagerPensar : MonoBehaviour
{
   public GameObject Dialogue;
   public Animator animatorControler;
    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private bool armandaHablaPrimero;

    [Header("Dialogo Texto")]
    [SerializeField] private TextMeshProUGUI armandaDialogoTexto;

    [Header("Botones Continuar")]
    [SerializeField] private GameObject armandaBotonContinuar;

    [Header("Animation Controllers")]
    [SerializeField] private Animator ArmandaBurbujaAnimator;

    [Header("Frases Dialogo")]
    [TextArea]
    [SerializeField] private string[] armandaDialogoFrases;

    private int armandaIndex;
    public SpriteRenderer spriteExclamacion;
    private float delayBurbujaAnimación = 0.5f;

    // Referencia al script de movimiento del personaje
    public ArmandaScript armandaScript;
    
    private bool dialogoActivo = true;

    public void TriggerDialoguePensar()
    {
        StartCoroutine(EmpezarDialogo());
    }


    private void Update()
    {
        if (armandaBotonContinuar.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(CerrarDialogoArmanda());
        }
    }
    
    public IEnumerator EmpezarDialogo()
    {
        // Desactivar el movimiento del personaje
        armandaScript.canMove = false;

        if (armandaHablaPrimero)
        {
            ArmandaBurbujaAnimator.SetTrigger("Abrir");
            animatorControler.SetBool("activaCamina", false);
            Dialogue.SetActive(dialogoActivo);
            yield return new WaitForSeconds(delayBurbujaAnimación);
            StartCoroutine(EscribeDialogoArmanda());
        }
    }

    private IEnumerator EscribeDialogoArmanda()
    {
         // Asegúrate de limpiar el texto antes de escribir
        foreach (char letter in armandaDialogoFrases[armandaIndex])
        {
            armandaDialogoTexto.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        armandaBotonContinuar.SetActive(true);
    }

    private IEnumerator CerrarDialogoArmanda()
    {
        yield return new WaitForSeconds(delayBurbujaAnimación);
        ArmandaBurbujaAnimator.SetTrigger("Cerrar");
        
        
        // Reactivar el movimiento del personaje
        armandaScript.canMove = true;
        animatorControler.SetBool("activaCamina", true);
    }
}