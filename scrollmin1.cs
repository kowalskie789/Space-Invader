using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollmin1 : MonoBehaviour
{
    private bool didity = false;
    public GameObject background1;
    public Vector3 position2;
    // Update is called once per frame
    void Update()
    {
        transform.position = ((transform.position) - (Vector3.up * scroll.scrollSpeed * Time.deltaTime));
        if(transform.position.y<0 && didity==false)
        {
            Instantiate(background1, position2, Quaternion.Euler(0, 0,180));
            didity = true;
        }

        if (transform.position.y < -30f)
        {
            Destroy(gameObject);
        }
    }
}
