using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DinoScript1 : MonoBehaviour
{
    public Rigidbody2D DinoBody;
    public int jumpHeight;
    private Vector3 angles = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.eulerAngles = angles;
        Vector3 temp = gameObject.transform.position;
        temp.x = -4;
        gameObject.transform.position = temp;
        if (Input.anyKey)
        {
            if (DinoBody.position.y <= 0)
            {
                DinoBody.velocity = Vector2.up * jumpHeight;
            }
        }
    }
}
