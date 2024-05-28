using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;


public class DialogueManager : MonoBehaviour
{
    public GameObject dialogoCaja;
    public UnityEvent onDialogStart;
    public UnityEvent onDialogEnd;
    public Animator animatorControler;

    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private bool ArmandaHablaPrimero;

    [Header("Dialogo Texto")]
    [SerializeField] private TextMeshProUGUI armandaDialogoTexto;
    [SerializeField] private TextMeshProUGUI gatinDialogoTexto;

    [Header("Botones Continuar")]
    [SerializeField] private GameObject armandaBotonContinuar;
    [SerializeField] private GameObject gatinBotonContinuar;

    [Header("Animation Controllers")]
    [SerializeField] private Animator ArmandaBurbujaAnimator;
    [SerializeField] private Animator GatinBurbujaAnimator;

    [Header("Frases Dialogo")]
    [TextArea]
    [SerializeField] private string[] armandaDialogoFrases;
    [TextArea]
    [SerializeField] private string[] gatinDialogoFrases;

    private bool dialogoEmpezado;
    private int armandaIndex;
    private int gatinIndex;

    private float delayBurbujaAnimación = 0.6f;

    // Referencia al script de movimiento del personaje
    public ArmandaScript armandaScript;

    public void TriggerDialogue()
    {
        StartCoroutine(EmpezarDialogo());
    }

    private void Update()
    {
        if (armandaBotonContinuar.activeSelf && Input.GetKeyDown(KeyCode.Return))
        {
            TriggerGatinDialogo();
        }

        if (gatinBotonContinuar.activeSelf && Input.GetKeyDown(KeyCode.Return))
        {
            TriggerArmandaDialogo();
        }
    }

    public IEnumerator EmpezarDialogo()
    {
        // Desactivar el movimiento del personaje
        armandaScript.canMove = false;
        animatorControler.SetBool("activaCamina", false);
          
      

        if (ArmandaHablaPrimero)
        {
            ArmandaBurbujaAnimator.SetTrigger("Abrir");
            yield return new WaitForSeconds(delayBurbujaAnimación);
            StartCoroutine(EscribeDialogoArmanda());
        }
        else
        {
            GatinBurbujaAnimator.SetTrigger("Abrir");
            yield return new WaitForSeconds(delayBurbujaAnimación);
            StartCoroutine(EscribeDialogoGatin());
        }
    }

    private IEnumerator EscribeDialogoArmanda()
    {
        armandaDialogoTexto.text = string.Empty;
        foreach (char letter in armandaDialogoFrases[armandaIndex])
        {
            armandaDialogoTexto.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        armandaBotonContinuar.SetActive(true);
    }

    private IEnumerator EscribeDialogoGatin()
    {
        gatinDialogoTexto.text = string.Empty;
        foreach (char letter in gatinDialogoFrases[gatinIndex])
        {
            gatinDialogoTexto.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        gatinBotonContinuar.SetActive(true);
    }

    private IEnumerator ContinuarDialogoArmanda()
    {
        gatinDialogoTexto.text = string.Empty;
        GatinBurbujaAnimator.SetTrigger("Cerrar");
        yield return new WaitForSeconds(delayBurbujaAnimación);

        armandaDialogoTexto.text = string.Empty;
        ArmandaBurbujaAnimator.SetTrigger("Abrir");
        yield return new WaitForSeconds(delayBurbujaAnimación);

        gatinBotonContinuar.SetActive(false);
        if (armandaIndex < armandaDialogoFrases.Length - 1)
        {
            if (dialogoEmpezado)
                armandaIndex++;
            else
                dialogoEmpezado = true;

            armandaDialogoTexto.text = string.Empty;
            StartCoroutine(EscribeDialogoArmanda());
        }
        else
        {
            // Finalizar el diálogo
            EndDialog();
        }
    }

    private IEnumerator ContinuarDialogoGatin()
    {
        armandaDialogoTexto.text = string.Empty;
        ArmandaBurbujaAnimator.SetTrigger("Cerrar");
        yield return new WaitForSeconds(delayBurbujaAnimación);

        gatinDialogoTexto.text = string.Empty;
        GatinBurbujaAnimator.SetTrigger("Abrir");
        yield return new WaitForSeconds(delayBurbujaAnimación);

        armandaBotonContinuar.SetActive(false);
        if (gatinIndex < gatinDialogoFrases.Length - 1)
        {
            if (dialogoEmpezado)
                gatinIndex++;
            else
                dialogoEmpezado = true;

            gatinDialogoTexto.text = string.Empty;
            StartCoroutine(EscribeDialogoGatin());
        }
        else
        {
            // Finalizar el diálogo
            EndDialog();
        }
    }

    public void TriggerArmandaDialogo()
    {
        gatinBotonContinuar.SetActive(true);

        if (armandaIndex >= armandaDialogoFrases.Length - 1)
        {
            gatinDialogoTexto.text = string.Empty;
            GatinBurbujaAnimator.SetTrigger("Cerrar");
            EndDialog();
        }
        else
        {
            StartCoroutine(ContinuarDialogoArmanda());
        }
    }

    public void TriggerGatinDialogo()
    {
        armandaBotonContinuar.SetActive(true);

        if (gatinIndex >= gatinDialogoFrases.Length - 1)
        {
            armandaDialogoTexto.text = string.Empty;
            ArmandaBurbujaAnimator.SetTrigger("Cerrar");
            EndDialog();
        }
        else
        {
            StartCoroutine(ContinuarDialogoGatin());
        }
    }

    private void EndDialog()
    {
        dialogoEmpezado = false;
        armandaScript.canMove = true;
        animatorControler.SetBool("activaCamina", true);
          
         // Reactivar el movimiento del personaje
    }
}