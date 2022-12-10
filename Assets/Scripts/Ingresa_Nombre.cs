using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Ingresa_Nombre : MonoBehaviour
{
    //Cambiar Nombres por el nombre de tu Script
    public static Ingresa_Nombre scene1;
    public TMP_InputField inputField;

    public string player_id;

    private void Awake()
    {
        if (scene1 == null)
        {
            scene1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerName()
    {
        player_id = inputField.text;

        SceneManager.LoadScene("Juego");
    }
}