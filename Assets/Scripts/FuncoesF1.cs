using UnityEngine;
using UnityEngine.SceneManagement;

public class FuncoesF1 : MonoBehaviour
{
    public bool Espada = false;
    public bool Capacete = false;
    public bool Escudo = false;
    public bool ArmNdShiel = false;
    public bool liberaEspada = false;
    [SerializeField] private Animator animPlayer;
    [SerializeField] private MovementPlayer move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
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
        Destroy(other.gameObject);
        Espada = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
