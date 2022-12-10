using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Avance_Tiempo : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI tiempo;


    // Start is called before the first frame update
    void Awake() {
        InvokeRepeating("Cronometro", 0f, 1f);
    }

    void Cronometro() {
        Singleton_Datos.datos_jugador.tiempo--;
        tiempo.text = Singleton_Datos.datos_jugador.tiempo.ToString();
        if (Singleton_Datos.datos_jugador.tiempo == -1) {
            SceneManager.LoadScene("ResultadoExamen");
        }
    }

}
