using UnityEngine;

public class AtivadorObjetos : MonoBehaviour
{
    private FuncoesF1 player;
    public GameObject maoEspada;
    public GameObject Escudo;
    public GameObject Capacete;

    void Start()
    {
        player = GameObject.FindFirstObjectByType<FuncoesF1>();        
    }


    void Update()
    {
        Ativando();
    }

    public void Ativando()
    {
        if(player.Espada == true)
        {
        maoEspada.SetActive(true);
        }

        if(player.Escudo == true)
        {
            Escudo.SetActive(true);
        }

        if(player.Capacete == true)
        {
            Capacete.SetActive(true);
        }
    }
}
