using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int movespeed;
    private Vector3 angles = Vector3.zero;
    public Logic logicscript;
    // Start is called before the first frame update
    void Start()
    {
        logicscript = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!logicscript.over)
        {
            gameObject.transform.eulerAngles = angles;
            transform.position += (Vector3.left * movespeed) * Time.deltaTime;
            if (transform.position.x < -15)
            {
                Debug.Log("Deleted enemy");
                Destroy(gameObject);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicscript.gameOver();
        logicscript.over = true;
    }
}
