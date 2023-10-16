using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosIf3 : MonoBehaviour
{
    /*
        EJERCICIO 3
    [SerializeField] private int num;
    void Start()
    {
        if (num < 0)
        {
            Debug.Log("El número es negativo");
        }
        else if(num>0)
        {
            Debug.Log("El número es positivo");
        }
        else
        {
            Debug.Log("El número es zero");
        }
    }
    */

    //EJERCICIO 4

    [SerializeField] private int nota;
    void Start()
    {
        if (nota < 5)
        {
            Debug.Log("Suspenso");
        }
        else if (nota < 7)
        {
            Debug.Log("Aprobado");
        }
        else if (nota < 9)
        {
            Debug.Log("Notable");
        }
        else
        {
            Debug.Log("Excelente");
        }
    }
}
