using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class particalSystem : MonoBehaviour {

    List<GameObject> particles = new List<GameObject>();

    public ParticleSystem a_particles;
    void Start()
    {
        a_particles = GetComponent<ParticleSystem>();
    }

    public void playParticleSystem()
    {    
        a_particles.Play();
        a_particles.loop = true;
    }
	
}
