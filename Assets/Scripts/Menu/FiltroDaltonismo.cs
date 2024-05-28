using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Procedo a comentar
public class FiltroDaltonismo : MonoBehaviour
{
    public Toggle toggleNone;
    public Toggle toggleProtanopia;
    public Toggle toggleDeuteranopia;
    void Start()
    {
        if(PlayerPrefs.GetInt("ToggleBool") == 1){
            toggleNone.isOn = true;
        }else{
            toggleNone.isOn = false;
        }
         if(PlayerPrefs.GetInt("ToggleBool2") == 1){
            toggleProtanopia.isOn = true;
        }else{
            toggleProtanopia.isOn = false;
        }
          if(PlayerPrefs.GetInt("ToggleBool3") == 1){
            toggleDeuteranopia.isOn = true;
        }else{
            toggleDeuteranopia.isOn = false;
        }
        
    }

    void Update()
    {
        if(toggleNone.isOn == true){
            PlayerPrefs.SetInt("ToggleBool1",1);
        }else{
            PlayerPrefs.SetInt("ToggleBool1",0);
        }

         if(toggleProtanopia.isOn == true){
            PlayerPrefs.SetInt("ToggleBool2",1);
        }else{
            PlayerPrefs.SetInt("ToggleBool2",0);
        }

         if(toggleDeuteranopia.isOn == true){
            PlayerPrefs.SetInt("ToggleBool3",1);
        }else{
            PlayerPrefs.SetInt("ToggleBool3",0);
        }
        }
    }

