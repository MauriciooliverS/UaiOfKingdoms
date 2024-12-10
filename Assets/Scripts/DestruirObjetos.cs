using Unity.VisualScripting;
using UnityEngine;

public class DestruirObjetos : MonoBehaviour
{
    public bool estaComChave = false;
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
    void RevelaSala()
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

            if(other.gameObject.CompareTag("Porta") )
        {
            if (Input.GetKey(KeyCode.E))
            {
                other.gameObject.GetComponent<Animator>().SetTrigger("abrePorta");
                RevelaSala();
            }
        }  
    }
}
}


