using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Audio : MonoBehaviour
{
    List<AudioClip> music_clip = new List<AudioClip>();

    public AudioSource radio;
    public AudioClip unit_sound;

    public void Play_Audio()
    {
        radio.clip = unit_sound;
        music_clip.Add(unit_sound);
        radio.Play();
    }
	
}
