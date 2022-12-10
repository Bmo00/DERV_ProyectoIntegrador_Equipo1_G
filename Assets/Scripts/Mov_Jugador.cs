using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mov_Jugador : MonoBehaviour
{
    [SerializeField]
    float velocidadRotacion = 200.0f;
    float velocidadMovimiento = 6.0f;
    float x, y;

    // Start is called before the first frame update
    void Start()
    {
        Singleton_Datos.datos_jugador.tiempo = 120;
    }

    // Update is called once per frame

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
    }
}
