using UnityEngine;
using UnityEngine.SceneManagement;

public class carregarcenas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Inicio()
    {
        SceneManager.LoadScene("Menu");
    }

    
    public void Fase1()
    {
        SceneManager.LoadScene("Fase1");
    }
}
