using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float rotacion = 10; //velocidad de Rotacion
    public float desplazamiento = 10; //Velocidad de Desplazamiento
    Rigidbody rb; //El GameObject al que se atache este Script debe contar con el componente Rigidbody

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Vinculación del objeto rb con el componente Rigidbody del GameObject
    }


    void Update()
    {
        //No utilizado en este script
    }


    void FixedUpdate() //Manera recomendada para operar con Fisicas
    {

        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("Arriba");
            rb.MovePosition(rb.position + transform.forward * desplazamiento * Time.fixedDeltaTime);
        }


        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("Atras");
            rb.MovePosition(rb.position + transform.forward * -1f * desplazamiento * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("Girar Izquierda"); //             X   Y  Z
            Quaternion q = Quaternion.Euler(new Vector3(0f, -1f, 0f) * rotacion * Time.fixedDeltaTime);

            rb.MoveRotation(rb.rotation * q);

        }

        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Girar Drecha"); //             X   Y  Z
            Quaternion q = Quaternion.Euler(new Vector3(0f, 1f, 0f) * rotacion * Time.fixedDeltaTime);

            rb.MoveRotation(rb.rotation * q);
        }


    }
}
