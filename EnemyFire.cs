using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject EnemyMissle;
    [Tooltip("less number, less fire")]
    public float Firerate;
    
    private float x;
    private int y;

    
     private GameObject[] activeenemies;
    // Start is called before the first frame update
    void Start()
    {
        activeenemies = new GameObject[GameObject.FindGameObjectsWithTag("Enemy").Length];


    }

    // Update is called once per frame
    void Update()
    {
        activeenemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (gameObject.GetComponent<EnemyHandler>().Bossison == true)
        {
           
            x = Random.Range(0, 98);
        }
        else
        {
            x = Random.Range(0, 100);
            
        }

        if (Firerate > x && activeenemies.Length >0)
        {
            for (int i = 0; i < activeenemies.Length; i++)
            {

                y = Random.Range(0, activeenemies.Length);
               
            }
           
            
            var clone = Instantiate(EnemyMissle, activeenemies[y].transform.position, Quaternion.Euler(0, 0, 180));
            
            if(gameObject.GetComponent<EnemyHandler>().Bossison == true)
            {
                
                var clone1 = Instantiate(EnemyMissle, activeenemies[y].transform.position, Quaternion.Euler(0, 0, 150));
                var clone2 = Instantiate(EnemyMissle, activeenemies[y].transform.position, Quaternion.Euler(0, 0, 210));
                Destroy(clone1, 3f);
                Destroy(clone2, 3f);
            }
            clone.transform.Translate(Vector2.down);
            Destroy(clone, 3f);
            

        }
    }
}
