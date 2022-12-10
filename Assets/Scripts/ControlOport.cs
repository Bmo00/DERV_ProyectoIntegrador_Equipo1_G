using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlOport : MonoBehaviour
{
    [SerializeField]
    int oports;
    // Start is called before the first frame update
    void Start()
    {
        Singleton_Datos.datos_jugador.tiempo = 120;
        Singleton_Datos.datos_jugador.oportunidades--;
        Debug.Log(Singleton_Datos.datos_jugador.oportunidades + " Oportunidades");
        Singleton_Datos.datos_jugador.calificacion = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
