using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosWhile3 : MonoBehaviour
{
    private int aux = 50;

    [SerializeField] private int num;
    private string aster = "";

    [SerializeField] private string pal;
    private int voc = 0;
    private int con = 0;

    private int pares = 0;
    private int impares = 0;

    [SerializeField] private int year1;
    [SerializeField] private int year2;

    //array del ejercicio 18
    [SerializeField] private float[] reales = { 1.9f, 2.4f, 4.9f };
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
            aux++;
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
        
        for(int i = 0; i < pal.Length; i++)
        {
            if (pal[i] == 'a' || pal[i] == 'e' || pal[i] == 'i' || pal[i] == 'o' || pal[i] == 'u')
            {
                voc++;
            }
            else if (pal[i] == 'A' || pal[i] == 'E' || pal[i] == 'I' || pal[i] == 'O' || pal[i] == 'U')
            {
                voc++;
            }
            else
            {
                con++;
            }
        }

        Debug.Log(pal + " tiene " + voc + " vocales, y " + con + " consonantes");
        
        //EJERCICIO 37

        for(int i = 0; i<=50; i+=2)
        {
            pares += i;
        }
        Debug.Log(pares);

        //EJERCICIO 38

        for (int i = 1; i <= 50; i += 2)
        {
            impares += i;
        }
        Debug.Log(impares);

        
        //EJERCICIO 39

        while (year1 <= year2)
        {
            if (year1 % 4 == 0)
            {
                if (year1 % 100 == 0)
                {
                    if (year1 % 400 == 0)
                    {
                        Debug.Log(year1 + " es Bisiesto");
                    }
                }
                else
                {
                    Debug.Log(year1 + " es Bisiesto");
                }
            }
            year1++;
        }

        //EJERCICIO 40

        for(int i = 0; i<reales.Length; i++)
        {
            Debug.Log((reales[i] * 3));
        }
        

    }


}
