using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCalculos : MonoBehaviour
{
    public int Num1;
    public int Num2;
    public int Resultado;
    // Start is called before the first frame update
    void Start()
    {
        Resultado = Num1 + Num1;
        Debug.Log(Resultado);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
