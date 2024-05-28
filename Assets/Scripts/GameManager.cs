using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public string DeDondeViene;

    public float tiempoMinijuego = 0.1f;

    void Awake()
    {
        if (Instance != null && Instance != this){
            Destroy(this.gameObject);
        }else{
            Instance=this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PasarEscena(){
        StartCoroutine(CorutinaAbrir());
    }
    private IEnumerator CorutinaAbrir(){
        yield return new WaitForSeconds(tiempoMinijuego);
        SceneManager.LoadScene("3.1_MINIJUEGO_GATIN");

    }
}
