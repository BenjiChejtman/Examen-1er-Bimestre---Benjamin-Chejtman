using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{

    public string nombre;
    public int año;
    public string orientacion;

    // Start is called before the first frame update
    void Start()
    {

        if (nombre == "")
        {
            Debug.Log("Escirba un nombre valido");
        }
        if (año > 0 && año < 3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        }
        else if (año < 1 || año > 5)
        {
            Debug.Log("Error, año ingresado invalido.");
        }        
        else if (nombre !="" && año >= 3 && año <= 5 && orientacion == "T" || orientacion == "D" || orientacion == "G" || orientacion == "M" || orientacion == "H")
        {
            Debug.Log("Muchas gracias " + nombre);
        }
        else if (orientacion != "T" || orientacion != "D" || orientacion != "G" || orientacion != "M" || orientacion != "H")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
