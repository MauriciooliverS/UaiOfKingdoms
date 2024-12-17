using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public FuncoesF2 puxaFuncoes;
    public GameObject gameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOver.SetActive(false);         
    }
    public void VivePlayer()
    {
        gameOver.SetActive(false); 
        SceneManager.LoadScene("Fase2");
        
    }

    // Update is called once per frame
    public void MorrePlayer()
    {
        gameOver.SetActive(true);
    }
    public void VoltaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
