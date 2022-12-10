using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Resultado_Final : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI Resumen, Calificacion, Correctas, Oportunidades;

    [SerializeField]
    Button reintentar, continuar;
    // Start is called before the first frame update
    void Start()
    {
        string aprobado="";
        if (Singleton_Datos.datos_jugador.calificacion > 70)
        {
            aprobado = "Aprobado";
            continuar.gameObject.SetActive(true);
        }
        else { 
            aprobado = "N/A";
            if (Singleton_Datos.datos_jugador.oportunidades > 0)
            {
                reintentar.gameObject.SetActive(true);
            }
            else
            {
                continuar.gameObject.SetActive(true);
            }
        }

        Resumen.text = "Resumen examen final: " + aprobado;
        Calificacion.text = "Califiacion final: " + Singleton_Datos.datos_jugador.calificacion + "/100 pts.";
        Correctas.text = "Respuestas correctas: " + Singleton_Datos.datos_jugador.calificacion / 20;
        Oportunidades.text = "Oportunidades restantes: " + Singleton_Datos.datos_jugador.oportunidades;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
