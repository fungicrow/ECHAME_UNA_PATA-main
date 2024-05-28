using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class sinRampaDialogo : MonoBehaviour
{
    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private TextMeshProUGUI panelSinRampa;
    [SerializeField] private string[] textoSinRampa;
    [SerializeField] private string[] textoReaccion;

    private int SinRampaIndex = 0;
    private int Reaccionindex;

    private bool textFinished = true;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(DialogoNoRampa());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator DialogoNoRampa(){
        foreach (char letter in textoSinRampa[SinRampaIndex].ToCharArray()){
            panelSinRampa.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void AceptarBoton(){
        if(textFinished == false) return;
        panelSinRampa.text = "";
        Debug.Log("Iniciamos");
        StartCoroutine(DialogoReaccion());
    }
    private IEnumerator DialogoReaccion(){
        textFinished = false;
        foreach (char letter in textoReaccion[Reaccionindex].ToCharArray()){
            panelSinRampa.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return new WaitForEndOfFrame();
        textFinished = true;

    }
}


