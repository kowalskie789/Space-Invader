using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{

    [SerializeField] public static float scrollSpeed = 1.5F;
    public GameObject background;
    public Vector3 position1;
    private void Start()
    {
        Instantiate(background, position1, Quaternion.Euler(0, 0,180));
    }

    private void Update()
    {
        transform.position=((transform.position)-(Vector3.up * scrollSpeed * Time.deltaTime));
     
        if(transform.position.y<-30f)
        {
            Destroy(gameObject);
        }
    }
}

