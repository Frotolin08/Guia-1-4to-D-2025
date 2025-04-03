using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEstacionamiento : MonoBehaviour
{
    public int horaActual;
    bool estaAbierto;
    // Start is called before the first frame update
    void Start()
    {
       
        if(horaActual<0 || horaActual>24)
        {

            Debug.Log("Se ha ingresado una hora incorrecta");
            return;
        }
        else if(horaActual >= 10 && horaActual<18)
        {
            estaAbierto = true;

        }
        else
        {
            estaAbierto = false;
        }
        Debug.Log("es " + estaAbierto + " que el estacionamiento esta abierto");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
