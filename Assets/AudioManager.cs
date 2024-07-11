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
        /*int index = Random.Range(0, 3);
        switch (index){
            case 0:
                musicSource.clip = Background;
        }*/

        musicSource.clip = Background;
        musicSource.Play();
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
