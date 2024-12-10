using UnityEngine;

public class AtivadorObjetos : MonoBehaviour
{
    private AnimationPlayer player;
    public GameObject maoEspada;

    void Start()
    {
        player = GameObject.FindFirstObjectByType<AnimationPlayer>();        
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
       //     escudos.SetActive(true);
        }

        if(player.Capacete == true)
        {
       //     capaceteC.SetActive(true);
        }
    }
}
