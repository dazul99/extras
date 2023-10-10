using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioUno : MonoBehaviour
{
    [SerializeField] private int num;
    void Start()
    {
        if (num >= 0)
        {
            Debug.Log("El número es positivo");
        }
        else
        {
            Debug.Log("El número NO es positivo");
        }
    }
}
