using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cerrarCartel : MonoBehaviour
{
    GameObject PopUp;
    // Start is called before the first frame update
    void Start()
    {
    PopUp = GameObject.Find("cartel_grande_edit");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        PopUp.SetActive(false);
   
   }
}
