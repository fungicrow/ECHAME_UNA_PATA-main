using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class rampaCortaDialogo : MonoBehaviour
{
    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private TextMeshProUGUI panelRampaCorta;
    [SerializeField] private string[] textoRampaCorta;
    [SerializeField] private string[] textoReaccion;

    private int CortaIndex = 0;
    private int Reaccionindex;

    private bool textFinished = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DialogoRampaCorta());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator DialogoRampaCorta(){
        foreach (char letter in textoRampaCorta[CortaIndex].ToCharArray()){
            panelRampaCorta.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void AceptarBoton(){
        if(textFinished == false) return;
        panelRampaCorta.text = "";
        Debug.Log("Iniciamos");
        StartCoroutine(DialogoReaccion());
    }
    private IEnumerator DialogoReaccion(){
        textFinished = false;
        foreach (char letter in textoReaccion[Reaccionindex].ToCharArray()){
            panelRampaCorta.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return new WaitForEndOfFrame();
        textFinished = true;

    }
}
