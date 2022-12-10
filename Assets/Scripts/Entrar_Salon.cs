using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrar_Salon : MonoBehaviour
{
    public GameObject bate;
    public GameObject objeto;
    [SerializeField]
    GameObject background;
    [SerializeField]
    GameObject presentar_examen;
    [SerializeField]
    GameObject texto_puerta_presentar;
    [SerializeField]
    GameObject flecha;

    // Start is called before the first frame update
    void Start()
    {
        background.SetActive(false);
        presentar_examen.SetActive(false);
        texto_puerta_presentar.SetActive(false);
        flecha.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (bate.GetComponent<Quitar_vida_bate>().zombies_derribados == 5)
        {
            if (objeto.GetComponent<Objetos>().v == 6)
            {
                background.SetActive(true);
                presentar_examen.SetActive(true);
                texto_puerta_presentar.SetActive(true);
                flecha.SetActive(true);
            }
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        Debug.Log(name);
        
        if (name == "Entrada_Salon")
        {
            if(presentar_examen.activeSelf)
            { 
                SceneManager.LoadScene("Presentacion");
            }
        }
    }
}
