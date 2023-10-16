using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosWhile2 : MonoBehaviour
{
    // Array de ejercicio 17
    [SerializeField] private string[] letras = { "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez" };
    void Start()
    {
        //EJERCICIO 31
        foreach (string letras in letras)
        {
            Debug.Log(letras + ", " + letras.Length);
        }

        //EJERCICIO 32
        foreach (string letras in letras)
        {
            if(letras.Length %2 == 0)
            {
                Debug.Log(letras);
            }
        }
    }

}
