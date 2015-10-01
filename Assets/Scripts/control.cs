using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

    public delegate void minefunction();
    minefunction function;

    void addnumber()
    {
        int result;
        result = 6 + 4;
        print("Result" + result.ToString());
    }

    enum state { idle, attack, death };
    void Start()
    {
        function += addnumber;
        function.Clone();
        
        //function(5);
        // test out FSM
        FSM<state> mineState = new FSM<state>();
        mineState.addState(state.idle);
        mineState.addState(state.idle);
        mineState.addState(state.attack);
        mineState.addState(state.attack);
<<<<<<< HEAD
        mineState.addDelegate("name", function);
        mineState.makeTransition(state.idle, state.attack, function);
        
=======
        
       // mineState.makeTransition(state.idle, state.attack);
>>>>>>> origin/master
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
