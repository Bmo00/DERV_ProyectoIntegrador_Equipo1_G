using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton_Datos : MonoBehaviour
{
    public static Singleton_Datos datos_jugador;

    public int oportunidades;
    public int calificacion;
    public int tiempo;

    private void Awake()
    {
        if (datos_jugador == null)
        {
            oportunidades = 3;
            calificacion=0;
            datos_jugador = this;
            tiempo = 120;
        }
        else //cuando no sea null
        {
            Destroy(this);
            //Destroy(gameObject);
        }
    }
}
