using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]private float speedX;
    [SerializeField]private float speedY;
    private MeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.mainTextureOffset = new Vector2 (speedY * Time.timeSinceLevelLoad, speedX * Time.timeSinceLevelLoad);
    }
}