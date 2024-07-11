using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header ("Audio Source ---------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio ---------")]
    public AudioClip Background;
    public AudioClip win;
    public AudioClip lose;
    public AudioClip die;
    public AudioClip jump;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playSFX(AudioClip audio)
    {
        SFXSource.PlayOneShot(audio);
    }
}
