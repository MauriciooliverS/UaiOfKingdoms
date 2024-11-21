using UnityEngine;

public class MenuCode : MonoBehaviour
{
    public GameObject creditos;
    public GameObject menu;
 
    public void Start()
    {
        creditos.SetActive(false);
        menu.SetActive(true);
 
    }
 
    public void Ativo()
    {
        creditos.SetActive(true);
        menu.SetActive(false);
    }
 
    public void Unable()
    {
        creditos.SetActive(false);
        menu.SetActive(true);
    }
}