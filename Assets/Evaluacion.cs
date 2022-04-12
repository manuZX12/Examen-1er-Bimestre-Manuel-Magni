using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluacion : MonoBehaviour
{
    public int entradasplatea;
    public int entradascampo;
    int preciocampo = 1200;
    int precioplatea = 2000;
    int camporecaudado;
    int platearecaudada;
    int dinerorecaudado;
    void Start()
    {
        if (entradascampo > 20400 || entradasplatea > 16200)
        {
            Debug.Log("El numero ingresado de entradas es incorrecto");
        }
        else
        {
            camporecaudado = (entradascampo * 1200);
            platearecaudada = (entradasplatea * 2000);
            dinerorecaudado = (camporecaudado + platearecaudada);
            Debug.Log("El dinero recuado por las entradas en platea es de " + platearecaudada + ". El dinero" +
                " recuadado por las entradas en el campo es de " + camporecaudado + " y el total recaudado es de " + dinerorecaudado + "");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
