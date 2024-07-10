using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int movespeed;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * movespeed) * Time.deltaTime;
        if (transform.position.x < -15)
        {
            Debug.Log("Deleted enemy");
            Destroy(gameObject);
        }
    }
}
