using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DinoScript : MonoBehaviour
{
    public Rigidbody2D DinoBody;
    public int jumpHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            if (DinoBody.position.y <= -1.1)
            {
                DinoBody.velocity = Vector2.up * jumpHeight;
            }
        }
    }
}
