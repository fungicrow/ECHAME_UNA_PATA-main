using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatinPrefab : MonoBehaviour
{
      public Transform seguirArmanda;
      public float distanciadeArmanda;
      public List<Vector2> posicion = new List<Vector2>();
      public float sampleDistancia;
      public float sampleTimeDifference;
      float sampleTime;
      public float removeDistance;
      public float velocidad;
      public float fastMarch;
      public float normalSpeed;
      public float fastDistance;

      private Animator animatorControler;



    // Start is called before the first frame update
    void Start()
    {
        sampleTime = Time.time;
        posicion.Add(seguirArmanda.position);
        velocidad=fastMarch;
        animatorControler=GetComponent<Animator>();
    }
 
    // Update is called once per frame
    void Update()
    {
        if(Time.time > sampleTime)
        {
            sampleTime = Time.time + sampleTimeDifference;

            if(Vector2.Distance(transform.position,seguirArmanda.position) > distanciadeArmanda &&
                Vector2.Distance(seguirArmanda.position, posicion[posicion.Count-1])>sampleDistancia)
            {
                posicion.Add(seguirArmanda.position);
            }

        }
        if(Vector2.Distance(transform.position,seguirArmanda.position)>fastDistance)
        {
            velocidad=fastMarch;
        }
        else
        {
            velocidad=normalSpeed;
        }
        if(Vector2.Distance(transform.position,seguirArmanda.position)>distanciadeArmanda)
        {
            transform.position = Vector2.MoveTowards(transform.position, posicion[0] , Time.deltaTime * velocidad);
            if(Vector2.Distance(transform.position, posicion[0]) < removeDistance)
            {
              if (posicion.Count > 1) { posicion.RemoveAt(0); }
            }
        }
    }
}
