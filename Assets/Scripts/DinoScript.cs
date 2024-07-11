using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DinoScript : MonoBehaviour
{
    public Rigidbody2D DinoBody;
    public int jumpHeight;
    private Vector3 angles = Vector3.zero;
    public Logic logicscript;
    public AudioManager audiomanager;
    private bool Jumpable;
    // Start is called before the first frame update
    void Start()
    {
        audiomanager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!logicscript.over)
        {
            gameObject.transform.eulerAngles = angles;
            Vector3 temp = gameObject.transform.position;
            temp.x = -7;
            gameObject.transform.position = temp;
            if (Input.anyKey)
            {
                if (Jumpable)
                {
                    audiomanager.playSFX(audiomanager.jump);
                    DinoBody.velocity = Vector2.up * jumpHeight;
                    Jumpable = false;
                }
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Jumpable = true;
    }
}
