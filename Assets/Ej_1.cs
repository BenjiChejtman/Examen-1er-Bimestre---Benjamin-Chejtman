using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_1 : MonoBehaviour
{
    public string nombre;
    public int año;
    public string orientacion;
    // Start is called before the first frame update
    void Start()
    { 
        if (año < 0 && año < 3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        }
        else if (año < 1 || año > 5)
        {
            Debug.Log("Error, año ingresado invalido.");
        }
        else if (año >= 3 && año <= 5 && orientacion == "T" || orientacion == "D" || orientacion == "G" || orientacion == "M" || orientacion == "M")
        {
            Debug.Log("Muchas gracias " + nombre);
        }
        else
        {
            Debug.Log("Escirba un nombre valido");
        }
    }
}

