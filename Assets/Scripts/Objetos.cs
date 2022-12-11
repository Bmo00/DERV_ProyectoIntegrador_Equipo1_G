using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI Objetos_txt;
    public int v = 0;


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
    }
}
