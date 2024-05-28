using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minijuegoSegisbuho : MonoBehaviour
{
    // Start is called before the first frame update
        GameObject selectSordoCiego;
        GameObject selectCegueraTotal;
        GameObject selectVisibilidadReducida;
    void Start()
    {
       selectSordoCiego = GameObject.Find("sordociego");
       selectSordoCiego.SetActive(false);
       selectCegueraTotal = GameObject.Find("ceguera_total");
       selectCegueraTotal.SetActive(false);
       selectVisibilidadReducida = GameObject.Find("visibilidad_reducida");
       selectVisibilidadReducida.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void botonAtras(){
        selectCegueraTotal.SetActive(false);
        selectSordoCiego.SetActive(false);
        selectVisibilidadReducida.SetActive(false);
    }

    public void bastonSordoCiego(){
        selectSordoCiego.SetActive(true);
    }

    public void bastonCegueraTotal(){
        selectCegueraTotal.SetActive(true);
    }

    public void bastonVisibilidadReducida(){
        selectVisibilidadReducida.SetActive(true);
    }
}
