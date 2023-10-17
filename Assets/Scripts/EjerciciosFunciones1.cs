using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EjerciciosFunciones1 : MonoBehaviour
{
    [SerializeField] private int count;
    [SerializeField] private int fact;
    [SerializeField] private int table;
    [SerializeField] private float real;
    [SerializeField] private string palabra;
    [SerializeField] private float precio;
    [SerializeField] private float descuento;
    [SerializeField] private int year;
    [SerializeField] private int numero;
    [SerializeField] private int numero2;
    [SerializeField] private int dias;
    [SerializeField] private int mes;
    [SerializeField] private int anyo;

    //EJERCICIO 41
    private void Countdown(int num)
    {
        Debug.Log(num);
        if (num > 0)
        {
            Countdown(num - 1);
        }
    }

    //EJERCICIO 42
    private int Factorial(int num)
    {
        if(num > 2) 
        {
            return (Factorial(num - 1) * num);
        }
        else
        {
            return 2;
        }
        
    }

    //EJERCICIO 43
    private void Tabla(int num)
    {
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log(i + " * " + num + " = " + (i * num));
        }
    }

    //EJERCICIO 44
    private void Sign(float num)
    {
        if (num > 0)
        {
            Debug.Log(num + " es positivo");
        }
        else if(num< 0)
        {
            Debug.Log(num + " es negativo");
        }
        else
        {
            Debug.Log(num + " es zero");
        }
    }

    //EJERCICIO 45
    private void VocalesConsonantes(string pal)
    {
        int voc = 0;
        int con = 0;
        for (int i = 0; i < pal.Length; i++)
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
    }

    //EJERCICIO 46
    private float Price(float precio, float descuento)
    {
        float resta = precio * (descuento/100); 
        return(precio-resta);
    }

    //EJERCICIO 47
    private bool Bisiestificanator(int year)
    {
        if (year % 4 == 0)
        {
            if(year % 100 == 0)
            {
                if(year%400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        else
        {
            return false;
        }
    }

    //EJERCICIO 48
    private void Pares(int num)
    {
        for (int i = 0; i < num; i++)
        {
            if(i%2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    //EJERCICIO 49
    private void ParImpar(int num)
    {
        if(num%2 == 0)
        {
            Debug.Log(num + " es par");
        }
        else
        {
            Debug.Log(num + " es impar");
        }
    }

    //EJERCICIO 50
    private int DiasPasados(int dias, int mes, int anyo) 
    {
        int total = 0;
        bool bis = Bisiestificanator(anyo);
        for(int sig = 1; sig != mes; sig++)
        {
            if (sig == 2)
            {
                total += 28;
                if (bis) total++;
            }
            else if (sig == 1 || sig == 3 || sig == 5 || sig == 7 || sig == 8 || sig == 10 || sig == 12)
            {
                total += 31;
            }
            else
            {
                total += 30;
            }
            sig++;
        }
        total += dias;
        return total;
        
    }


    void Start()
    {
        Countdown(count);
        Factorial(fact);
        Tabla(table);
        Sign(real);
        VocalesConsonantes(palabra);
        Price(precio, descuento);
        Bisiestificanator(year);
        Pares(numero);
        ParImpar(numero2);
        DiasPasados(dias, mes, anyo);
    }

}
