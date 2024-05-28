using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class rampaBienDialogo : MonoBehaviour
{
    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private TextMeshProUGUI panelBien;
    [SerializeField] private string[] textoBien;
    //[SerializeField] private string[] textoReaccion;

    private int BienIndex = 0;
    //private int Reaccionindex;

    //private bool textFinished = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DialogoBien());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator DialogoBien(){
        foreach (char letter in textoBien[BienIndex].ToCharArray()){
            panelBien.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
