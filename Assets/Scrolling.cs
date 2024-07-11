using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public SpriteRenderer floor;
    private Material _material;
    public Logic logicscript;
    public float speed;
    public float currentscroll;
    void Start()
    {
        currentscroll = 0;
        _material = floor.material;
    }

    void Update()
    {
        if (!logicscript.over){
            currentscroll += speed * Time.deltaTime;
            _material.mainTextureOffset = new Vector2(currentscroll, 0);
        }
    }

}
