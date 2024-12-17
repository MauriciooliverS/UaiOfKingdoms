using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FuncoesF2 : MonoBehaviour
{
    public GameOver puxaGameOver;
    public bool estaComChave = false;
    public bool portaAberta = false;
    [SerializeField] private Animator animPlayer;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animPlayer = GetComponent<Animator>();
        puxaGameOver = GameObject.FindFirstObjectByType<GameOver>();
        
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
        if(other.gameObject.CompareTag("Saida"))
        
        {
        
            SceneManager.LoadScene("Menu");
        }
    }
    public void PlayerMorto()
    {
        Time.timeScale = 0;
        puxaGameOver.MorrePlayer();
    }
    public void PlayerVivo()
    {
        Time.timeScale = 1;
       
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if(collision.gameObject.CompareTag("Morte"))
        {
            animPlayer.SetTrigger("Morte");
            PlayerMorto();
        }
}
}

