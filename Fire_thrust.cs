using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_thrust : MonoBehaviour
{
    private Rigidbody2D r;
    public float speed;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        r.transform.Translate(Vector2.up*speed);
    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
           // Debug.Log("Colision");
            var exp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(exp, 1);
            Destroy(gameObject);
        }
        }
}
