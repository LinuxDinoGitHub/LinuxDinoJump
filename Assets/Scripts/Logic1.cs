using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logic1 : MonoBehaviour
{
    public AudioManager Audiomanager;
    private void Start()
    {
        Audiomanager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        Audiomanager.playSFX(Audiomanager.Background);
    }
    public void PlayGame()
    {
        Debug.Log("Switching scenes");
        SceneManager.LoadScene(1);
    }
}
