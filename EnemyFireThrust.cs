using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireThrust : MonoBehaviour
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
       
       r.transform.Translate(new Vector2(0,(speed*Time.deltaTime)));

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Colision");
            UIManager.Life--;
            var exp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(exp, 1);
            Destroy(gameObject);
        }
    }
}
