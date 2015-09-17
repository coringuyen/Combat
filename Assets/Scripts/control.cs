using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

    FSM takeAction;

    void Start()
    {
        takeAction = GetComponent<FSM>();
    }

    public void init_to_idle()
    {
        takeAction.Transition(FSM.States.init, FSM.States.idle);
    }

    public void idle_to_attack()
    {
        takeAction.Transition(FSM.States.idle, FSM.States.attack);
    }

    public void idle_to_block()
    {
        takeAction.Transition(FSM.States.idle, FSM.States.block);
    }

}
