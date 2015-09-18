using UnityEngine;
using System.Collections;

public class FSM : MonoBehaviour
{

    public enum States { init, idle, death, attack, block };
    //States actions = States.init;

    public delegate void attack(GameObject player);
    public delegate void block (GameObject player);
    public delegate void death (GameObject player);
    public delegate void init  (GameObject player);

    void Start()
    {
        //Transition(States.idle, States.attack);   
    }

    public void Transition(States currentstate, States gotostate)
    {
        if (currentstate == States.init && gotostate == States.idle)
        {
            print("Idle!");
        }

        if (currentstate == States.idle && gotostate == States.attack)
        {
            GetComponent<Audio>().Attack_Audio(gameObject);
            print("Attack!");
        }

        if (currentstate == States.idle && gotostate == States.block)
        {
            GetComponent<Audio>().Block_Audio(gameObject);
            print("Block");
        }
    }
}
