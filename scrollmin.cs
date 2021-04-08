using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollmin : MonoBehaviour
{
    private bool didit = false;
    public GameObject background;
    public Vector3 position1;
    // Update is called once per frame
    void Update()
    {
        transform.position = ((transform.position) - (Vector3.up * scroll.scrollSpeed * Time.deltaTime));
        if(transform.position.y<0 && didit==false)
        {
            Instantiate(background, position1, Quaternion.Euler(0, 180, 0));
            didit = true;
        }

        if (transform.position.y < -30f)
        {
            Destroy(gameObject);
        }
    }
}
