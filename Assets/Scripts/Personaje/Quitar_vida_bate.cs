using UnityEngine;
using TMPro;

public class Quitar_vida_bate : MonoBehaviour
{
    public int damage;
    public GameObject Enemigo1;
    public GameObject Enemigo2;
    public GameObject Enemigo3;
    public GameObject Enemigo4;
    public GameObject Enemigo5;
    public int zombies_derribados;
    [SerializeField]
    TextMeshProUGUI Enemys_txt;
    // Start is called before the first frame update
    void Start()
    {
        zombies_derribados = 0;
        damage = 20;
        //cc = GetComponent<CharacterController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        Debug.Log(name);
        if (name == "Enemigo_Estres")
        {
            Enemigo1.GetComponent<vida_enemigo_1>().vidaEnemigo -= damage;
            if (Enemigo1.GetComponent<vida_enemigo_1>().vidaEnemigo <= 0)
            {
                zombies_derribados++;
                Debug.Log("ZOMBIES DERRIBADOS: " + zombies_derribados);
                Enemys_txt.text = "ENEMIGOS DERRIBADOS:\n" + zombies_derribados.ToString() + "/5";
            }
        }
        else if (name == "Enemigo_Ansiedad")
        {
            Enemigo2.GetComponent<vida_enemigo_2>().vidaEnemigo -= damage;
            if (Enemigo2.GetComponent<vida_enemigo_2>().vidaEnemigo <= 0)
            {
                zombies_derribados++;
                Debug.Log("ZOMBIES DERRIBADOS: " + zombies_derribados);
                Enemys_txt.text = "ENEMIGOS DERRIBADOS:\n" + zombies_derribados.ToString() + "/5";
            }
        }
        else if (name == "Enemigo_Miedo")
        {
            Enemigo3.GetComponent<vida_enemigo_3>().vidaEnemigo -= damage;
            if (Enemigo3.GetComponent<vida_enemigo_3>().vidaEnemigo <= 0)
            {
                zombies_derribados++;
                Debug.Log("ZOMBIES DERRIBADOS: " + zombies_derribados);
                Enemys_txt.text = "ENEMIGOS DERRIBADOS:\n" + zombies_derribados.ToString() + "/5";
            }
        }
        else if (name == "Enemigo_Tristeza")
        {
            Enemigo4.GetComponent<vida_enemigo_4>().vidaEnemigo -= damage;
            if (Enemigo4.GetComponent<vida_enemigo_4>().vidaEnemigo <= 0)
            {
                zombies_derribados++;
                Debug.Log("ZOMBIES DERRIBADOS: " + zombies_derribados);
                Enemys_txt.text = "ENEMIGOS DERRIBADOS:\n" + zombies_derribados.ToString() + "/5";
            }
        }
        else if (name == "Enemigo_Rechazo")
        {
            Enemigo5.GetComponent<vida_enemigo_5>().vidaEnemigo -= damage;
            if (Enemigo5.GetComponent<vida_enemigo_5>().vidaEnemigo <= 0)
            {
                zombies_derribados++;
                Debug.Log("ZOMBIES DERRIBADOS: " + zombies_derribados);
                Enemys_txt.text = "ENEMIGOS DERRIBADOS:\n" + zombies_derribados.ToString() + "/5";
            }
        }
    }
}
