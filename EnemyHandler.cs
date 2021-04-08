using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    public Vector2[] enemyPositions;
    public GameObject enemyPrefab;
    public GameObject BossPrefab;
    public Vector2 startposition;
    private GameObject[] enemy;
    private int wawecounter = 0;
    public bool Bossison = false;

    private bool spawncheck = false;
    private bool destruction = false;

    // Start is called before the first frame update
    void Start()
    {
        enemy = new GameObject[enemyPositions.Length];
        StartGame();
      

    }

    // Update is called once per frame
    void Update()
    {
        
        if(GameObject.FindGameObjectsWithTag("Enemy") == null && spawncheck == false)
        {
            wawecounter++;
            Bossison = false;
        }
        /*
        if (new Vector2(enemy[0].transform.position.x, enemy[0].transform.position.y) == new Vector2(enemyPositions[0].x, enemyPositions[0].y - (0.5f)))
        {
            for (int a = 0; a < enemy.Length; a++)
            {
                StartCoroutine(Move_Routine(enemy[a].transform, enemy[a].transform.position, (enemyPositions[a] )));

            }
        }
        */
       
            if (GameObject.FindGameObjectsWithTag("Enemy") == null && spawncheck == false)
            {
                if (wawecounter == 4 || wawecounter == 8)
                {
                StartCoroutine(SpawnBoss());
                spawncheck = true;
                
                return;

                }
                if(wawecounter == 12)
                {

                StartCoroutine(SpawnThreeBoss());
                spawncheck = true;
                return;

                }
                else
                {
                    
                    Debug.Log("fala " + wawecounter + " pokonana");
                    SpawnEnemies();
                for (int a = 0; a < enemy.Length; a++)
                {
                    StartCoroutine(Move_Routine(enemy[a].transform, enemy[a].transform.position, (enemyPositions[a])));

                }
                destruction = false;
                return;
                }
          
            
        }
        //włączanie zniszczenia statków
        if(destruction == false)
        {
            if(enemy[1].transform.position.y<10 )
            {
                for (int m = 0; m < enemy.Length; m++)
                {
                    enemy[m].transform.GetChild(0).gameObject.layer = 11;
                }
                destruction = true;
            }
        }

    }
   
   void StartGame()
    {
        SpawnEnemies();
       
    }
    public IEnumerator Move_Routine(Transform transform, Vector3 from, Vector3 to)
    {
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime*0.25f;
            transform.position = Vector2.Lerp(from, to, Mathf.SmoothStep(0f, 1f, t));
            
            yield return null;
        }
        
       
    }
    void SpawnEnemies()
    {
        for (int i = 0; i < enemyPositions.Length; i++)
        {
            enemy[i] = Instantiate(enemyPrefab, startposition, Quaternion.identity);
            StartCoroutine(Move_Routine(enemy[i].transform, startposition, enemyPositions[i]));
               
        }
    }
    IEnumerator SpawnBoss()
    {
        // tutaj przyspieszanko mapki na razie nie diała jak chcę 
        for (int f = 0; f < 250; f++)
        {
            scroll.scrollSpeed = scroll.scrollSpeed + 0.3f;
            yield return new WaitForSeconds(0.01f);
        }

        for (int f = 0; f < 250; f++)
        {
            scroll.scrollSpeed = scroll.scrollSpeed - 0.3f;
            yield return new WaitForSeconds(0.01f);
        }
        
        enemy[7] = Instantiate(BossPrefab, startposition, Quaternion.identity);
            StartCoroutine(Move_Routine(enemy[7].transform, startposition, enemyPositions[7] + new Vector2(0, -(0.5f))));
            Bossison = true;
        spawncheck = false;
        yield return null;

    }
    IEnumerator SpawnThreeBoss()
    {
        for (int f = 0; f < 250; f++)
        {
            scroll.scrollSpeed = scroll.scrollSpeed + 0.3f;
            yield return new WaitForSeconds(0.01f);
        }

        for (int f = 0; f < 250; f++)
        {
            scroll.scrollSpeed = scroll.scrollSpeed - 0.3f;
            yield return new WaitForSeconds(0.01f);
        }
        enemy[7] = Instantiate(BossPrefab, startposition, Quaternion.identity);
        StartCoroutine(Move_Routine(enemy[7].transform, startposition, enemyPositions[7] + new Vector2(0, -(0.5f))));
        enemy[1] = Instantiate(BossPrefab, startposition, Quaternion.identity);
        StartCoroutine(Move_Routine(enemy[1].transform, startposition, enemyPositions[1] + new Vector2(0, -(0.5f))));
        enemy[12] = Instantiate(BossPrefab, startposition, Quaternion.identity);
        StartCoroutine(Move_Routine(enemy[12].transform, startposition, enemyPositions[12] + new Vector2(0, -(0.5f))));
        Bossison = true;
        spawncheck = false;
        yield return null;
    }
    

}
