using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrimerEntrarEstacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){

        GameManager.Instance.DeDondeViene=SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("2.MAPA2_1");
    }
}
