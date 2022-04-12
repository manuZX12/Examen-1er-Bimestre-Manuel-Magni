using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evaluacion : MonoBehaviour
{
    public int entradasplatea;
    public int entradascampo;
    int camporecaudado;
    int platearecaudada;
    int dinerorecaudado;
    int plateasobrante;
    int camposobrante;
    int entradastotales;
    void Start()
    {
        plateasobrante = (16200 - entradasplatea);
        camposobrante = (20400 -  entradascampo);
        entradastotales = (entradascampo + entradasplatea);
        if (entradascampo > 20400 || entradasplatea > 16200 || entradasplatea <= -1 || entradascampo <= -1)
        {
            Debug.Log("El numero ingresado de entradas es incorrecto");
        }
        else if (plateasobrante > 0 || camposobrante > 0 || entradastotales >= 18300)
        {
            camporecaudado = (entradascampo * 1200);
            platearecaudada = (entradasplatea * 2000);
            dinerorecaudado = (camporecaudado + platearecaudada);
            Debug.Log("El dinero recuado por las entradas en platea es de " + platearecaudada + ". El dinero" +
                " recuadado por las entradas en el campo es de " + camporecaudado + " y el total recaudado es de " + dinerorecaudado + "");
            Debug.Log("Quedaron " + plateasobrante + " vacantes en platea y " + camposobrante + " vacantes en el campo.");
            Debug.Log("El festival fue un éxito!");
        }
        else if (plateasobrante > 0 || camposobrante > 0 || entradastotales < 18300)
        {
            camporecaudado = (entradascampo * 1200);
            platearecaudada = (entradasplatea * 2000);
            dinerorecaudado = (camporecaudado + platearecaudada);
            Debug.Log("El dinero recuado por las entradas en platea es de " + platearecaudada + ". El dinero" +
                " recuadado por las entradas en el campo es de " + camporecaudado + " y el total recaudado es de " + dinerorecaudado + "");
            Debug.Log("Quedaron " + plateasobrante + " vacantes en platea y " + camposobrante + " vacantes en el campo.");
            Debug.Log("Debemos mejorar la convocatoria");
        }
        else if (plateasobrante == 0 || camposobrante == 0)
        {
            camporecaudado = (entradascampo * 1200);
            platearecaudada = (entradasplatea * 2000);
            dinerorecaudado = (camporecaudado + platearecaudada);
            Debug.Log("El dinero recuado por las entradas en platea es de " + platearecaudada + ". El dinero" +
                " recuadado por las entradas en el campo es de " + camporecaudado + " y el total recaudado es de " + dinerorecaudado + "");
            Debug.Log("Sold Out");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
