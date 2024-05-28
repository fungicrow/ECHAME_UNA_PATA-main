using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogominijuegoSegisbuho : MonoBehaviour
{

    [SerializeField] private float typingSpeed = 0.05f;
    [SerializeField] private TextMeshProUGUI principalSegisbuho;
    [SerializeField] private string[] textoSegisbuho1;
    

    private int segisbuhoIndex;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DialogoStart1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator DialogoStart1(){
        foreach (char letter in textoSegisbuho1[segisbuhoIndex].ToCharArray()){
            principalSegisbuho.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
