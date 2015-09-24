using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    public GameObject unit;

    Factory Test;
    Audio Audio_test;
    particalSystem particle_test;

    void Start()
    {
        Test = GetComponent<Factory>();
        Audio_test = GetComponent<Audio>();
        particle_test = GetComponent<particalSystem>();
    }

    void Update ()
    {
        Test.MakeUnit(unit);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Audio_test.Play_Audio();
            particle_test.playParticleSystem();
        }
        
        
	}
}
