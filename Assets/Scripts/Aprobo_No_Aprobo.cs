using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Aprobo_No_Aprobo : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI texto;
    [SerializeField]
    GameObject img_ganar;
    [SerializeField]
    GameObject img_perder;
    // Start is called before the first frame update
    void Start()
    {
        if (Singleton_Datos.datos_jugador.calificacion > 70) {
            texto.text = " LO LOGRASTE!!!! ";
            img_ganar.SetActive(true);
            img_perder.SetActive(false);
        }
        else {
            texto.text = "PERDISTE :C";
            img_ganar.SetActive(false);
            img_perder.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
