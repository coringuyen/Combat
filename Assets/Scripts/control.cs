using UnityEngine;
using System.Collections;

public class control : MonoBehaviour
{

    delegate void hi();
    hi Hi;

    FSM<state> mineState = new FSM<state>();
   

    enum state { idle, talk, leave };
    void Start()
    {
        Hi += hello;
        Hi += bye;     
        
        mineState.addState(state.idle);
        mineState.addState(state.talk);
        mineState.addState(state.leave);

        mineState.current_state = state.idle;
        Debug.Log(mineState.current_state.ToString());
        mineState.addTransition(state.idle, state.talk, Hi);
        //mineState.addTransition(state.talk, state.leave, bye);

    }
    void Update()
    {
        test();
    }

    void test()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            mineState.ChangeState(state.talk);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            mineState.ChangeState(state.leave);
        }
    }

    void hello()
    {
        Debug.Log("Hello!");
    }

    void bye()
    {
        Debug.Log("GoodBye!");
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
