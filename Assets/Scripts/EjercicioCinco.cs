using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCinco : MonoBehaviour
{
    [SerializeField] private float precio;
    [SerializeField] private float porcentajeDescuento;
    private float descuento;
    void Start()
    {
        porcentajeDescuento /= 100;
        descuento = precio * porcentajeDescuento;
        Debug.Log("El precio final es de " + (precio - descuento));
    }

}
