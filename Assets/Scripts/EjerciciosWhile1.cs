using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosWhile1 : MonoBehaviour
{
    private int aux = 1;

    [SerializeField] private int fact = 0;
    private int mult;

    [SerializeField] private int tabla;

    [SerializeField] private int aster;
    private int it1 = 0;
    private string asteriscos = "";
    void Start()
    {
        //EJERCICIO 26
        while (aux <= 10)
        {
            Debug.Log(aux);
            aux++;
        }

        //EJERCICIO 27
        for (int i = 15;  i >= 0; i--)
        {
            Debug.Log(i);
        }

        //EJERCICIO 28
        for (int i = 1; i <= fact; i++)
        {
            if (i == 1)
            {
                mult = i;
            }
            else
            {
                mult *= fact;
            }

        }
        Debug.Log(mult);

        //EJERCICIO 29
        for(int i = 0;i <= 10; i++)
        {
            Debug.Log(i + " * " + tabla + " = " + (i * tabla));
        }

        //EJERCICIO 30
        while(it1!=aster)
        {
            asteriscos += "*";
            Debug.Log(asteriscos);
            it1++;

        }
    }

}
