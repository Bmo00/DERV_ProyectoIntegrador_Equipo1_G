using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hacer_Pregunta : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI numPreg, pregunta, respA, respB, respC, respD, texto, calif;
    [SerializeField]
    Transform origen;
    int numeroPregunta, correctas;
    int[] examen;
    string[,] lista_Preg = {{"En arquitectura de computdoras, ¿Que es RAM?","a) Marca de Camioneta","b) Memoria de Acceso Aleatorio","c) Nombre de un juego","d) Ninguna","b"},
                                  {"En redes, ¿Que es Metropolitana?","a) Una red que interconecta las redes de distintas ciudades","b) El parque ubicado en Tampico","c) Un restaurante","d) Ninguna","a"},
                                  {"En Entornos de ralidad virtual, ¿Compara dos cadenas de texto en C#?","a) /","b) >","c) !=","d) ==","d"},
                                  {"En sistemas operativos, el sistema operativo es:","a) El software almacenado en el hardware","b) La unidad elemental de información","c)  La forma de almacenar datos","d) Un conjunto de programas que se encargan de controlar la computadora","d"},
                                  {"En arquitectura de computdoras, es componente interno de una Computadora","a) Teclado","b) Disco duro","c) Usuario","d) Monitor","b"},
                                  {"En cultura general, es el nombre del diretor de FIANS","a) Dr. Alejandro García","b) Miguel Angel Sanchez","c) Dr. Roberto Pichardo Ramirez","d) Ninguna","c"},
                                  {"En arquitectura de computdoras, es donde se almacena la Bios","a) En la ROM","b) Memoria Flash","c) RAM","d) En el celular","a"},
                                  {"En arquitectura de computdoras, son modelos de arquitectura de computo:","a) Clasca y sermentada","b) Unica","c) Estrella","d) Cableado estructurado","a"},
                                  {"En redes, que caracteristicas debe tener un red de area local","a) Velocidad","b) Ninguna","c) Compartir recursos","d) Comunicarse con el exterior","c"},
                                  {"En redes, es un componente de una red","a) HDD","b) El usuario","c) El escritorio","d) El switch","d"},
                                  {"En redes, cuantos bits compone el protocolo TCP/IP","a) 32","b) 8","c) 64","d) 128","a"},
                                  {"En redes, se define como el Protocolo de Control de Transmision","a) TPC","b) CPU","c) Disco duro","d) La red LAN","a"},
                                  {"En redes, es una IP valida","a) 292.168.1.254","b) 168.292.1.254","c) 10.256.256.1","d) 192.168.0.1","d"},
                                  {"En base de datos corporativa, es la accion de obtener la informacion deseada a partir de los datos almacenados en fuentes externas","a) Carga","b) Extraccion","c) Transformacion","d) Todas","b"},
                                  {"En base de datos corporativa, una tabla de hechos esta creada a traves de sumas, promedio o manipulando los datos en una tabla de dimensiones","a) Cierto","b) Falso ","c) No se sabe","d) Ninguna","a"},
                                  {"En evaluacion de proyectos de ingenieria, Es una medida abstracta que calcula el promedio necesario por persona","a) Mano de obra","b) Relacion hora persona","c) Esfuerzo","d) Casos de uso","c"},
                                  {"En realidad virtual, Metodo con el cual se llama a cada cuadro y permite que el Gizmo en cuestion este siempre visible","a) OnGizmosCheck","b) OnPaintingGizmos","c) OnGizmos","d) OnDrawGizmos","d"},
                                  {"En realidad virtual, Instruccion que indica a Unity que una variable publica o privada estara visible en el inspector","a) private","b) public","c) SerializeField","d) static","c"},
                                  {"En realidad virtual, es un contenedor de datos que se puede usar para guardar largas cantidades de datos, independientes de las instancias de clase","a) Singleton","b) ScriptableObject","c) Transform","d) GameObject","a"},
                                  {"En cultura general, como se llama coloquialmente a la zona donde venden comida sobre la barda de la UAT","a) El Mercadito","b) La Nave","c) El Pasillo del Colera","d) Fonditas","c"},

    };

    // Start is called before the first frame update
    void Start()
    {
        Singleton_Datos.datos_jugador.tiempo = 120;
        numeroPregunta = 0;
        correctas = 0;
        examen = new int[5];
        inicio();
        

    }

    void inicio() {
        for (int i = 0; i < 5;)
        {
            int rdm = Random.Range(0, 20);
            bool existe = false;
            for (int j = 0; j < i && existe == false; j++)
            {
                if (rdm == examen[j])
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                examen[i] = rdm;
                i++;
            }
        }
        HacerPregrunta();
    }

    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;

        if (name == lista_Preg[examen[numeroPregunta], 5])
        {
            correctas++;
            Singleton_Datos.datos_jugador.calificacion += 20;
            calif.text = "Calificacion al momento: " + Singleton_Datos.datos_jugador.calificacion;
        }
        if (numeroPregunta < 4)
        {
            StartCoroutine("Espera");
            Debug.Log(numeroPregunta);
            numeroPregunta++;
            HacerPregrunta();
        }
        else
        {
            SceneManager.LoadScene("ResultadoExamen");
        }
    }
       
    

    IEnumerator Espera() {
            yield return new WaitForSeconds(0.15f);
            transform.position = origen.position;
    }

    void HacerPregrunta() {

        numPreg.text = (numeroPregunta + 1).ToString();
        pregunta.text = lista_Preg[examen[numeroPregunta], 0];
        respA.text = lista_Preg[examen[numeroPregunta], 1];
        respB.text = lista_Preg[examen[numeroPregunta], 2];
        respC.text = lista_Preg[examen[numeroPregunta], 3];
        respD.text = lista_Preg[examen[numeroPregunta], 4];
        
    }
}
