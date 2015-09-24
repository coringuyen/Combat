using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

    enum state { idle, attack, death };
    void Start()
    {
        // test out FSM
        FSM<state> mineState = new FSM<state>();
        mineState.addState(state.idle);
        mineState.addState(state.idle);
        mineState.addState(state.attack);
        mineState.addState(state.attack);
        
       // mineState.makeTransition(state.idle, state.attack);
    }

    public void init_to_idle()
    {
        //takeAction.Transition(FSM.States.init, FSM.States.idle);
    }

    public void idle_to_attack()
    {
        //takeAction.Transition(FSM.States.idle, FSM.States.attack);
    }

    public void idle_to_block()
    {
        //takeAction.Transition(FSM.States.idle, FSM.States.block);
    }

}
