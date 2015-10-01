using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    public AudioClip attack_audio;
    public AudioClip block_audio;
    public AudioClip dead_audio;

    //FSM.attack Attack;
    //FSM.block Block;
    //FSM.death Death;

    //void Start()
    //{
    //    Attack += Attack_Audio;
    //    Block += Block_Audio;
    //    Death += Dead_Audio;
    //}

    public void Attack_Audio(GameObject player, bool a_switch)
    {
        if (player && a_switch == true)
        {
            player.GetComponent<AudioSource>().clip = attack_audio;
            player.GetComponent<AudioSource>().Play();
        }

        else if (player && a_switch == false)
        {
            player.GetComponent<AudioSource>().Stop();
        }
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
