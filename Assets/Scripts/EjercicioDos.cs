using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDos : MonoBehaviour
{
    [SerializeField] private int num;
    void Start()
    {
        if (num < 0)
        {
            Debug.Log("El n�mero es negativo");
        }
        else
        {
            Debug.Log("El n�mero NO es negativo");
        }
    }
}
