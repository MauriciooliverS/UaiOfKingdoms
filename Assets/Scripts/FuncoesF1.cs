using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FuncoesF1 : MonoBehaviour
{
    public bool portaAberta = false;
    public bool Espada = false;
    public bool Capacete = false;
    public bool Escudo = false;
    [SerializeField] private Animator animPlayer;
    [SerializeField] private MovementPlayer move;

    void Start()
    {
        
     
    }
        void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Portao"))
        {
            if(Espada == true)
            {
                SceneManager.LoadScene("Fase2");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Espada"))
        {
            Destroy(other.gameObject);
            Espada = true;
        }
        if(other.gameObject.CompareTag("Capacete"))
        {
            Destroy(other.gameObject);
            Capacete = true;
        }
        if(other.gameObject.CompareTag("Escudo"))
        {
            Destroy(other.gameObject);
            Escudo = true;
        }  
    }

    void OnTriggerStay(Collider other)
    {
            if(other.gameObject.CompareTag("Porta") )
        {
            if (Input.GetKey(KeyCode.E))
            {
                other.gameObject.GetComponent<Animator>().SetTrigger("abrePorta");        
                portaAberta = true;
            }
        }
    }

}
