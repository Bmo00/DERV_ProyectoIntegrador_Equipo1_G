using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarrarArma : MonoBehaviour
{

    public GameObject []arma;

    public LogicaPersonaje logicaPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarArma (int numero)
    {
        print(numero);
        arma[numero].SetActive(true);
        logicaPersonaje.tengoArma = true;
    }
}
