using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class vida_FPC : MonoBehaviour
{
    public bool aumentar_vida = false;
    public float cronometro;
    [SerializeField]
    GameObject Efecto_Vida;

    void Start()
    {
        vidaPlayer = 100;
        Efecto_Vida.SetActive(false);
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("arma"))
        {
            print("Daño");
        }
 
        if (coll.CompareTag("Zona_Regenerar_Vida"))
        {
            aumentar_vida = true;
            Efecto_Vida.SetActive(true);

            print("Regenerar Vida");
        }

        if (coll.CompareTag("Quitar_Regeneracion"))
        {
            aumentar_vida = false;
            Efecto_Vida.SetActive(false);
        }
    }
    public int vidaPlayer;
    public Slider vidaVisual;
    private void Update()
    {
        cronometro += 1 * Time.deltaTime;
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;
        if(vidaPlayer <= 0 )
        {
            SceneManager.LoadScene("Perdiste");
            Debug.Log("GAME OVER");
        }
        if (aumentar_vida == true)
        {
            if (cronometro > 2)
            {
                if (vidaPlayer <= 95)
                {
                    vidaPlayer = vidaPlayer + 5;
                }
                else if(vidaPlayer < 100)
                {
                    vidaPlayer++;
                }
                cronometro = 0;
            }
        }
    }
}
