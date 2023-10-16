using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosIf8 : MonoBehaviour
{
    // EJERCICIO 13
    [SerializeField] private float altura;
    [SerializeField] private float anchura;

    //EJERCICIO 14
    [SerializeField] private int anyoNacimiento;
    [SerializeField] private int anyoActual;

    //EJERCICIO 15
    [SerializeField] private float num1;
    [SerializeField] private float num2;
    [SerializeField] private string ope;

    void Start()
    {
        // EJERCICIO 13
        Debug.Log("El area del rectangulo es de " + (altura * anchura));

        // EJERCICIO 14
        Debug.Log("El sujeto tiene " + (anyoActual - anyoNacimiento) + " años");

        // EJERCICIO 15
        if (ope == "addition")
        {
            Debug.Log((num1 + num2));
        }
        else if (ope == "subtraction")
        {
            Debug.Log((num1 - num2));
        }
        else if (ope == "product")
        {
            Debug.Log((num1 * num2));
        }
        else if (ope == "division")
        {
            Debug.Log((num1 / num2));
        }
        else
        {
            Debug.Log("operación no válida");
        }
    }



}