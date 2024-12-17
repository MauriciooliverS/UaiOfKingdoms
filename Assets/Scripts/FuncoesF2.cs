using Unity.VisualScripting;
using UnityEngine;

public class FuncoesF2 : MonoBehaviour
{
    public bool estaComChave = false;
    public bool portaAberta = false;
    [SerializeField] private Animator animPlayer;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animPlayer = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }    
    void OnTriggerStay(Collider other)
    {
        
        if(other.gameObject.CompareTag("Chave"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(other.gameObject);
                estaComChave = true;
            }
        }

        if(other.gameObject.CompareTag("Comida"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(other.gameObject);
            }
        }

        if(other.gameObject.CompareTag("Porta") )
        {
            if (Input.GetKey(KeyCode.E) && estaComChave == true)
            {
                other.gameObject.GetComponent<Animator>().SetTrigger("abrePorta");
               portaAberta = true;        
                
            }
        }  
        if(other.gameObject.CompareTag("OcultaSala"))
        
        {
        
            Destroy(other.gameObject);
        }
    }
}

