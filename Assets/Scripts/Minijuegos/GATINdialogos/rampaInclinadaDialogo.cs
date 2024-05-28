using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class rampaInclinadaDialogo : MonoBehaviour
{
    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private TextMeshProUGUI panelRampaInclinada;
    [SerializeField] private string[] textoRampaInclinada;
    [SerializeField] private string[] textoReaccion;

    private int InclinadaIndex = 0;
    private int Reaccionindex;

    private bool textFinished = true;

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(DialogoRampaInclinada());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private IEnumerator DialogoRampaInclinada(){
        foreach (char letter in textoRampaInclinada[InclinadaIndex].ToCharArray()){
            panelRampaInclinada.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void AceptarBoton(){
        if(textFinished == false) return;
        panelRampaInclinada.text = "";
        Debug.Log("Iniciamos");
        StartCoroutine(DialogoReaccion());
    }
    private IEnumerator DialogoReaccion(){
        textFinished = false;
        foreach (char letter in textoReaccion[Reaccionindex].ToCharArray()){
            panelRampaInclinada.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return new WaitForEndOfFrame();
        textFinished = true;

    }

}
