using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
   public float parallaxSpeed=1;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       transform.position= new Vector3(Camera.main.transform.position.x/parallaxSpeed,Camera.main.transform.position.y/parallaxSpeed,0);
      
    }
}
