using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int life = 3;
    private float x;
    public GameObject gift;
    private GameObject g;
    
    private void Update()
    {
      
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "Missle")
        {
            
            life--;
            if (life < 0)
            {
                Destroy(gameObject);
                x = Random.Range(0f, 1f);
                if (x>(0.9f))
                {
                    Gift();
                }
            }

            }
    }
    private void Gift()
    {
       g= Instantiate(gift, transform.position, Quaternion.identity);
        
    }
}
