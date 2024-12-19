using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Textos : MonoBehaviour
{
    public AnimationPlayer player;
    public GameObject cTutor1;
    public GameObject cTutor2;
    

    void Start()
    {
        player = GetComponent<AnimationPlayer>();
        cTutor1.SetActive(true);
        cTutor2.SetActive(false);
       
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Tutorial"))
        {
            cTutor1.SetActive(false);
            cTutor2.SetActive(true);
        }
        
        if(other.gameObject.CompareTag("Misson"))
        {
           
            cTutor2.SetActive(false);
        }
    }
}
