using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cargar_Scenes : MonoBehaviour
{

    public void LoadScene(string nombre) 
    {
        SceneManager.LoadScene(nombre);
    }
}
