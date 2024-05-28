using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrincipalDialogo : MonoBehaviour
{

    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private TextMeshProUGUI panelPrincipal;
    [SerializeField] private string[] textoPrincipal;
    //[SerializeField] private string[] textoReaccion;

    private int PrincipalIndex = 0;
    //private int Reaccionindex;

    //private bool textFinished = true;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(DialogoPrincipal());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DialogoPrincipal(){
        foreach (char letter in textoPrincipal[PrincipalIndex].ToCharArray()){
            panelPrincipal.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    /*public void AceptarBoton(){
        if(textFinished == false) return;
        panelInclinado.text = "";
        Debug.Log("Iniciamos");
        StartCoroutine(DialogoReaccion());
    }
    private IEnumerator DialogoReaccion(){
        textFinished = false;
        foreach (char letter in textoReaccion[Reaccionindex].ToCharArray()){
            panelInclinado.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return new WaitForEndOfFrame();
        textFinished = true;

    }*/
}
