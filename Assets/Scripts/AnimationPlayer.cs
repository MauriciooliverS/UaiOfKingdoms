using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] private Animator animPlayer;
    [SerializeField] private MovementPlayer move;
    private bool estaNoChao = true;
 
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animPlayer = GetComponent<Animator>();
        move = GetComponent<MovementPlayer>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
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
        if(collision.gameObject.CompareTag("Morte"))
        {
            animPlayer.SetTrigger("Morte");
            Time.timeScale = 0;
        }
}
}
