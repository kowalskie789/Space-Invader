using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject missle;
    public Transform[] startfire;
    [SerializeField] public static int FireLevel = 0;
    

    // Update is called once per frame
    void Update()
    {
        if (FireLevel == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var clone = Instantiate(missle, startfire[0].position, Quaternion.identity);
                Destroy(clone, 1f);
            }
        }
        if(FireLevel==1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var clone = Instantiate(missle, startfire[1].position, Quaternion.identity);
                var clone1 = Instantiate(missle, startfire[2].position, Quaternion.identity);
                Destroy(clone, 2f);
                Destroy(clone1, 2f);
            }
        }
        if (FireLevel == 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var clone = Instantiate(missle, startfire[0].position, Quaternion.identity);
                var clone1 = Instantiate(missle, startfire[3].position, Quaternion.identity);
                var clone2 = Instantiate(missle, startfire[4].position, Quaternion.identity);
                Destroy(clone, 2f);
                Destroy(clone1, 2f);
                Destroy(clone2, 2f);

            }
        }
        if (FireLevel == 3)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var clone = Instantiate(missle, startfire[0].position, Quaternion.identity);
                var clone1 = Instantiate(missle, startfire[1].position, Quaternion.identity);
                var clone2 = Instantiate(missle, startfire[3].position, Quaternion.identity);
                var clone3 = Instantiate(missle, startfire[4].position, Quaternion.identity);
                Destroy(clone, 2f);
                Destroy(clone1, 2f);
                Destroy(clone2, 2f);
                Destroy(clone3, 2f);
            }
        }
        if (FireLevel == 4)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var clone = Instantiate(missle, startfire[0].position, Quaternion.identity);
                var clone1 = Instantiate(missle, startfire[1].position, Quaternion.identity);
                var clone2 = Instantiate(missle, startfire[3].position, Quaternion.identity);
                clone2.transform.rotation = Quaternion.Euler(0, 0, 35);
                var clone3 = Instantiate(missle, startfire[4].position, Quaternion.identity);
                clone3.transform.rotation = Quaternion.Euler(0, 0, -35);
                Destroy(clone, 2f);
                Destroy(clone1, 2f);
                Destroy(clone2, 2f);
                Destroy(clone3, 2f);
            }
        }
        if (FireLevel == 5)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var clone = Instantiate(missle, startfire[0].position, Quaternion.identity);
                var clone1 = Instantiate(missle, startfire[1].position, Quaternion.identity);
                var clone2 = Instantiate(missle, startfire[3].position, Quaternion.identity);
                clone2.transform.rotation = Quaternion.Euler(0, 0, 35);
                var clone3 = Instantiate(missle, startfire[4].position, Quaternion.identity);
                clone3.transform.rotation = Quaternion.Euler(0, 0, -35);
                var clone4 = Instantiate(missle, startfire[3].position, Quaternion.identity);
                var clone5 = Instantiate(missle, startfire[4].position, Quaternion.identity);
                Destroy(clone, 2f);
                Destroy(clone1, 2f);
                Destroy(clone2, 2f);
                Destroy(clone3, 2f);
                Destroy(clone4, 2f);
                Destroy(clone5, 2f);
            }
        }
        if (FireLevel >= 6)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var clone = Instantiate(missle, startfire[0].position, Quaternion.identity);
                var clone1 = Instantiate(missle, startfire[1].position, Quaternion.identity);
                var clone2 = Instantiate(missle, startfire[3].position, Quaternion.identity);
                clone2.transform.rotation = Quaternion.Euler(0, 0, 35);
                var clone3 = Instantiate(missle, startfire[4].position, Quaternion.identity);
                clone3.transform.rotation = Quaternion.Euler(0, 0, -35);
                var clone4 = Instantiate(missle, startfire[3].position, Quaternion.identity);
                var clone5 = Instantiate(missle, startfire[4].position, Quaternion.identity);
                var clone6 = Instantiate(missle, startfire[1].position, Quaternion.identity);
                clone6.transform.rotation = Quaternion.Euler(0, 0, 25);
                var clone7 = Instantiate(missle, startfire[2].position, Quaternion.identity);
                clone7.transform.rotation = Quaternion.Euler(0, 0, -25);
                Destroy(clone, 2f);
                Destroy(clone1, 2f);
                Destroy(clone2, 2f);
                Destroy(clone3, 2f);
                Destroy(clone4, 2f);
                Destroy(clone5, 2f);
                Destroy(clone6, 2f);
                Destroy(clone7, 2f);

            }
        }





    }
}
