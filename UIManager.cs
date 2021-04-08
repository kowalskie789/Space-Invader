using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject[] Heart;
    public static int Life;
    // Start is called before the first frame update
    void Start()
    {
        Life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Life; i++)
        {
            Heart[i].SetActive(true);
        }
        for (int i = 0; i < (Heart.Length-Life); i++)
        {
            if (Life >= 0)
            {
                Heart[i + Life].SetActive(false);
            }
        }
        if(Life<0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
