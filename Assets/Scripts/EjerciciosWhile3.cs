using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosWhile3 : MonoBehaviour
{
    private int aux = 50;

    [SerializeField] private int num;
    private string aster = "";

    [SerializeField] private string pal;
    void Start()
    {
        //EJERCICIO 33
        while(aux > 0)
        {
            if(aux %2 ==0) 
            {
                Debug.Log(aux);
            }
            aux--;
        }

        //EJERCICIO 34
        aux = 1;
        while (aux <= 100)
        {
            if (aux % 5 == 0)
            {
                Debug.Log(aux);
            }
            aux--;
        }

        //EJERCICIO 35

        for (int i = 0; i<num; i++)
        {
            aster += "*";
        }
        for (int i = 0; i < num; i++)
        {
            Debug.Log (aster);
        }

        //EJERCICIO 36


    }


}
