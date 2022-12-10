using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desbloquear_puerta : MonoBehaviour
{
    public GameObject Enemigos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemigos.GetComponent<Quitar_vida_bate>().zombies_derribados == 3)
        {
            Debug.Log("MISION LOGRADA");
            Destroy(gameObject);
        }
    }
}
