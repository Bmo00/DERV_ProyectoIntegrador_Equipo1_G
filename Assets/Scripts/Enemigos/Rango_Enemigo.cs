using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rango_Enemigo : MonoBehaviour
{
    public Animator ani;
    public enemigo1 enemigo;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            //if(!enemigo.stuneado)
            //{
            ani.SetBool("walk", false);
            ani.SetBool("run", false);
            ani.SetBool("attack", true);
            enemigo.atacando = true;
            GetComponent<CapsuleCollider>().enabled = false;
            //}
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
