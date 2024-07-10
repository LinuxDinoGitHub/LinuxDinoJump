using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 2;
    private float timer = 0;
    public Logic logicscript;
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!logicscript.over)
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                spawnEnemy();
                timer = 0;
                spawnRate = Random.Range(1, 3);
            }
        }
    }
    void spawnEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
