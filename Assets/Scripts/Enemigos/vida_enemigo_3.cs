using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vida_enemigo_3 : MonoBehaviour
{
    public int vidaEnemigo;
    public Slider vidaEVisual;
    public float cronometro;
    // Start is called before the first frame update
    void Start()
    {
        vidaEnemigo = 150;
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("bate"))
        {
            print("Daño");
        }
    }

    // Update is called once per frame
    void Update()
    {
        cronometro += 1 * Time.deltaTime;
        vidaEVisual.GetComponent<Slider>().value = vidaEnemigo;
        if (vidaEnemigo <= 0)
        {
            Debug.Log("ZOMBIE DERRIBADO");
            Destroy(gameObject);
        }
        else if (vidaEnemigo < 150)
        {
            if (cronometro > 2)
            {
                if (vidaEnemigo <= 145)
                {
                    vidaEnemigo = vidaEnemigo + 5;
                }
                else if (vidaEnemigo < 150)
                {
                    vidaEnemigo++;
                }
                cronometro = 0;
            }
        }
    }
}
