using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosDiezOnceYDoce : MonoBehaviour
{
    /*
     * EJERCICIO 10
    [SerializeField] private int dia;
    [SerializeField] private int mes;
    private int total = 0;
    private int sig = 1;
    // Start is called before the first frame update
    void Start()
    {
      while (sig != mes)
        {
            if(sig == 2)
            {
                total += 28;
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
        total += dia;
        Debug.Log("Han pasado un total de " + total + " dias");
    }
    */

    /*
     * EJERCICIO 11
    [SerializeField] private int anyo;
    void Start()
    {
        if (anyo % 4 == 0)
        {
            if(anyo % 100==0)
            {
                if (anyo % 400 == 0)
                {
                    Debug.Log("Es Bisiesto");
                }
                else
                {
                    Debug.Log("NO es Bisiesto");
                }
            }
            else
            {
                Debug.Log("Es Bisiesto");
            }
        }
        else
        {
            Debug.Log("NO es Bisiesto");
        }
    }
    */

    //EJERCICIO 12
    [SerializeField] private int dia;
    [SerializeField] private int mes;
    [SerializeField] private int anyo;
    private bool bis = false;
    private int total = 0;
    private int sig = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (anyo % 4 == 0)
        {
            if (anyo % 100 == 0)
            {
                if (anyo % 400 == 0)
                {
                    bis = true;
                }
            }
            else
            {
                bis = true;
            }
        }
        while (sig != mes)
        {
            if (sig == 2)
            {
                total += 28;
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
        total += dia;
        if(bis)
        {
            total++;
        }
        Debug.Log("Han pasado un total de " + total + " dias");
    }

}
