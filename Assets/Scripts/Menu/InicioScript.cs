using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioScript : MonoBehaviour
{
    //Me gusta la numeración, viva la numeración...
    //Mariano guapo
    //Este es un segundo comentario
    //Este es un tercer comentario
    //Otro comentario pa variar

    GameObject panelSettings;
    // Start is called before the first frame update
    void Start()
    {
        panelSettings = GameObject.Find("PanelSettings");
        panelSettings.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        SceneManager.LoadScene("1MAPA1");
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void MostrarSettings(){
        panelSettings.SetActive(true);
    }

    public void OcultarSettings(){
        panelSettings.SetActive(false);
    }
}

