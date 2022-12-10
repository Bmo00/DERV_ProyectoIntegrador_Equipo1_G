using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cambio_escena : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("Laberinto");
        //SceneManager.LoadScene(sceneName);
    }
}
