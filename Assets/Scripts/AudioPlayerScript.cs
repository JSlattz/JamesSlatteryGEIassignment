using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioPlayerScript : MonoBehaviour
{

    public AudioSource MyAudioSource;
    public AudioClip[] AudioList;

    [RequireComponent(typeof(AudioSource))]
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
