using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocaArmanda : MonoBehaviour
{
    public GameObject spawnFuera;
    public GameObject spawnVias;

    public GameObject Armanda;
    // Start is called before the first frame update
    void Start()
    {


        if (GameManager.Instance.DeDondeViene == "fuera"){
            Armanda.transform.position  = spawnFuera.transform.position;
        }        
        
        if (GameManager.Instance.DeDondeViene == "vias"){
            Armanda.transform.position  = spawnVias.transform.position;
        }

        Debug.Log(GameManager.Instance.DeDondeViene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
