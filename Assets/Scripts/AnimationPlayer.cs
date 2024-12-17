using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationPlayer : MonoBehaviour
{
    public GameOver puxaGameOver;
    [SerializeField] private Animator animPlayer;
    [SerializeField] private MovementPlayer move;
    private bool estaNoChao = true;
    private bool tutor;
 
    
    void Start()
    {
        
        animPlayer = GetComponent<Animator>();
        move = GetComponent<MovementPlayer>();
        Time.timeScale = 1;
    }

    void Update()
    {
        //Pulando
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao)
        {
            animPlayer.SetBool("NoChao", false);
            animPlayer.SetTrigger("Pulo");
            move.Pular();
            estaNoChao = false;
        }
    }
    void FixedUpdate()
    {
        //Andando para frente
        if (Input.GetKey(KeyCode.W))
        {
            animPlayer.SetBool("Andar", true);
            move.Andar();
        }
        else
        {
            animPlayer.SetBool("Andar", false);
        }

        //Andando para trás
        if (Input.GetKey(KeyCode.S))
        {
            animPlayer.SetBool("AndarTras", true);
            move.Andar();
        }
        else
        {
            animPlayer.SetBool("AndarTras", false);
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            move.Virar();
            animPlayer.SetBool("Andar", true);
        }

        //Correndo
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            animPlayer.SetBool("Correr", true);
        }
        else
        {
            animPlayer.SetBool("Correr", false);
        }

        //Torcida
        if(Input.GetKey(KeyCode.Q))
        {
            animPlayer.SetTrigger("Torcida");
        }

        //Interagindo
        if (Input.GetKey(KeyCode.E))
        {
            animPlayer.SetTrigger("Interagir");
        }

        //Pegando
        if (Input.GetKey(KeyCode.G))
        {
            animPlayer.SetTrigger("Pegar");
        }

        //Atacando
        if (Input.GetMouseButton(0))
        {
            animPlayer.SetTrigger("Ataque");
        }

        
    }
   

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Chao"))
        {
            animPlayer.SetBool("NoChao", true);
            estaNoChao = true;
        }
<<<<<<< HEAD
    }
=======
        if(collision.gameObject.CompareTag("Morte"))
        {
            animPlayer.SetTrigger("Morte");
            Time.timeScale = 0;
        }
    }

    
>>>>>>> 4290d78110b9c08399259552e8f6c25d91c2c2dc
}
