using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymissle : MonoBehaviour
{
    private Rigidbody2D rigid;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.transform.Translate(Vector2.down*0.1f);
        Destroy(this, 5f);

    }
}
