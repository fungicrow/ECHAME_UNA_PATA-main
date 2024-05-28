using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogoSordoCiego : MonoBehaviour
{

    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private TextMeshProUGUI panelSordociego;
    [SerializeField] private string[] textoSordociego;

    [SerializeField] private string[] textoReaccion;

    private int Reaccionindex;

    private int sordociegoIndex;

    private bool textFinished = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DialogoStart2());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DialogoStart2(){
        foreach (char letter in textoSordociego[sordociegoIndex].ToCharArray()){
            panelSordociego.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void AceptarBoton(){
        if(textFinished == false) return;
        panelSordociego.text = "";
        Debug.Log("Iniciamos");
        StartCoroutine(DialogoReaccion());
    }
    private IEnumerator DialogoReaccion(){
        textFinished = false;
        foreach (char letter in textoReaccion[Reaccionindex].ToCharArray()){
            panelSordociego.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return new WaitForEndOfFrame();
        textFinished = true;

    }
}
