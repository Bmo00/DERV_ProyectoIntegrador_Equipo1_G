using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI Objetos_txt;
    //[SerializeField]
    //GameObject Efecto_Vida;
    public int v = 0;
    void Start()
    {
        //Llaves_txt.text = v.ToString();
        //Efecto_Vida.SetActive(false);
    }


    private void OnCollisionEnter(Collision collision)
    {
        string name;
        string tag;

        name = collision.gameObject.name;
        tag = collision.gameObject.tag;
        if (tag.Equals("Objeto"))
        {
            GameObject obj = GameObject.Find(name);

            Destroy(obj, 0);
            v = v + 1;
            Objetos_txt.text = "OBJETOS ENCONTRADOS:\n" + v.ToString() + "/6";
        }
        //if (v == 3)
        //{
        //   Salida.SetActive(true);
        //}
    }

    //Necesita un Collider dentro de los objetos, puede ser box o mesh o el que sea, tambien asignar un tag a los objetos, en este caso el tag es "Objeto", este script va en el personaje,
    //finalmente el txt es el contador, lo comentado es la forma de salir cuando se recogen todos los objetos, activando el GameObject salida, el cual puede ser un trigger o lo que quieran ponerle

}
