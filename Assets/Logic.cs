using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public int score = 0;
    public Text scoreDisplay;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (timer < 0.02)
        {
            timer += Time.deltaTime;
        }
        else
        {
            score += 1;
            scoreDisplay.text = score.ToString("D6");
            timer = 0;
        }
    }
}
