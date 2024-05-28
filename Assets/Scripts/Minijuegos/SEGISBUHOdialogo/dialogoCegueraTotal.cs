using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class dialogoCegueraTotal : MonoBehaviour
{

    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private TextMeshProUGUI panelCegueraTotal;
    [SerializeField] private string[] textoCegueraTotal;

    private int cegueratotalIndex;

    [SerializeField] private string[] textoReaccion;
      private int Reaccionindex;

    private bool textFinished = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DialogoStart3());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DialogoStart3(){
        foreach (char letter in textoCegueraTotal[cegueratotalIndex].ToCharArray()){
            panelCegueraTotal.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void AceptarBoton(){
        if(textFinished == false) return;
        panelCegueraTotal.text = "";
        Debug.Log("Iniciamos");
        StartCoroutine(DialogoReaccion());
    }
    private IEnumerator DialogoReaccion(){
        textFinished = false;
        foreach (char letter in textoReaccion[Reaccionindex].ToCharArray()){
            panelCegueraTotal.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        yield return new WaitForEndOfFrame();
        textFinished = true;
        StartCoroutine(WaitCorutine(2f));
    }

    public IEnumerator WaitCorutine(float time){
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("2.3_MAPA2_sinNPC2");
        
    }
}
