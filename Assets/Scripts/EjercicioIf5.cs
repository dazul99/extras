using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioIf5 : MonoBehaviour
{
    [SerializeField] private float lado1;
    [SerializeField] private float lado2;
    [SerializeField] private float lado3;

    // Start is called before the first frame update
    void Start()
    {
        if (lado1 == lado2 && lado2 == lado3)
        {
            Debug.Log("Es un triangulo equilátero");
        }
        else if(lado1 == lado2 || lado2 == lado3 || lado1==lado3)
        {
            Debug.Log("Es un triangulo isósceles");
        }
        else
        {
            Debug.Log("Es un triangulo escaleno");
        }
    }

  
}
