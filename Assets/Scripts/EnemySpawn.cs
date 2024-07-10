using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawn : MonoBehaviour
{
    public List<GameObject> prefabList = new List<GameObject>();
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public float spawnRate = 2;
    private float timer = 0;
    public float offsety = 1.43f;
    public Logic logicscript;
    // Start is called before the first frame update
    void Start()
    {
        prefabList.Add(enemy1);
        prefabList.Add(enemy2);
        prefabList.Add(enemy3);
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
        int prefabIndex = UnityEngine.Random.Range(0, prefabList.Count);
        if (prefabIndex != 2)
        {
            Instantiate(prefabList[prefabIndex], transform.position, transform.rotation);
        }
        else
        {
            Vector3 vector3 = transform.position;
            Instantiate(prefabList[prefabIndex], new Vector3(vector3.x, offsety * -1, vector3.z), transform.rotation);
        }
    }
}
