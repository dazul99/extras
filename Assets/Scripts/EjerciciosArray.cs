using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosArray : MonoBehaviour
{
    //EJERCICIO 16
    [SerializeField] private int[] array = { 1, 2, 3, 4, 5 };

    //EJERCICIO 17
    [SerializeField] private string[] letras = {"uno", "dos", "tres", "cuatro", "cinco","seis","siete","ocho","nueve","diez" };

    //EJERCICIO 18
    [SerializeField] private float[] reales = {1.9f, 2.4f, 4.9f };

    //EJERCICIO 19
    [SerializeField] private string[] vocales = {"a", "e", "i", "o", "u" };
    void Start()
    {
        //EJERCICIO 20
        Debug.Log(array[0]);

        //EJERCICIO 21
        Debug.Log(letras[9]);

        //EJERCICIO 22
        reales[1] = 1.5f;

        //EJERCICIO 23
        Debug.Log("la cuarta vocal es " + vocales[3]);

        //EJERCICIO 24
        Debug.Log(letras.Length);

        //EJERCICIO 25
        Debug.Log(array[0] + array[4]);
    }

}
