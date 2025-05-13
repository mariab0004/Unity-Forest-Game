using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public int hit;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Sphere")
        {
            hit--;
            if(hit == 0)
            {
                Destroy(gameObject);
            }
        }
    }
    
}