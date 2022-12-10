using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Nombre_Personaje : MonoBehaviour
{
    public TextMeshPro display_name;

    private void Awake()
    {
        display_name.text = Ingresa_Nombre.scene1.player_id;
    }
}
