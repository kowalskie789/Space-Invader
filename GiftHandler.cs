using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 20);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0.5f, 0);
        gameObject.transform.Translate(new Vector3(0,-0.01f,0));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Depo")
        {
            Debug.Log("Colision");
            if (UIManager.Life < 10)
            {
                UIManager.Life++;
            }
            Fire.FireLevel++;
            Destroy(gameObject);
        }
    }
}
