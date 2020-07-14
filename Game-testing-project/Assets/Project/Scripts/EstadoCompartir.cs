using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstadoCompartir : MonoBehaviour
{
    // Start is called before the first frame update
    public int cont =0;
    public static EstadoCompartir estadoComr;

 
    
    void Awake()
    {
        
            DontDestroyOnLoad(gameObject);

    }
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
