using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptConversion : MonoBehaviour
{
public string moneda;
public float monto;
float cotizacion;
    // Start is called before the first frame update
    void Start()
    {
	if(monto<1000)
	{
	Debug.Log("El monto mínimo es $1000");
	Return();
	}
	else
	{
	if(moneda=="D")
	{
	cotizacion = 1310f;

	}
	else if(moneda == "R")
	{
	cotizacion = 183.1f;

	}
	else if(moneda =="E")
	{
	cotizacion = 1179.15;

	}
	else
	{
	Debug.Log("Opción de moneda extranjera no válida");
	Return();

	}
	Debug.Log(cotizacion.monto);
	}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
