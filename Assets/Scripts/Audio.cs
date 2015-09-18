using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

    public AudioClip attack_audio;
    public AudioClip block_audio;
    public AudioClip dead_audio;


    public void Attack_Audio(GameObject player)
    {
        player.GetComponent<AudioSource>().clip = attack_audio;
        player.GetComponent<AudioSource>().Play();
    }

    public void Block_Audio(GameObject player)
    {
        player.GetComponent<AudioSource>().clip = block_audio;
        player.GetComponent<AudioSource>().Play();
    }

    public void Dead_Audio(GameObject player)
    {
        player.GetComponent<AudioSource>().clip = dead_audio;
        player.GetComponent<AudioSource>().Play();
    }


}
