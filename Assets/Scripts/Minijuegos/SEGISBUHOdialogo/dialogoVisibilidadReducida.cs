using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogoVisibilidadReducida : MonoBehaviour
{
    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private TextMeshProUGUI panelVisibilidadReducida;
    [SerializeField] private string[] textoVisibilidadReducida;

    private int visibilidadreducidaIndex;

    [SerializeField] private string[] textoReaccion;

    private int Reaccionindex;

    private bool textFinished = true;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DialogoStart4());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DialogoStart4(){
        foreach (char letter in textoVisibilidadReducida[visibilidadreducidaIndex].ToCharArray()){
            panelVisibilidadReducida.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

     public void AceptarBoton(){
        if(textFinished == false) return;
        panelVisibilidadReducida.text = "";
        Debug.Log("Iniciamos");
        StartCoroutine(DialogoReaccion());
    }
    private IEnumerator DialogoReaccion(){
        textFinished = false;
        foreach (char letter in textoReaccion[Reaccionindex].ToCharArray()){
            panelVisibilidadReducida.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return new WaitForEndOfFrame();
        textFinished = true;
}
}