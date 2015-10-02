using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class TeacherTest : MonoBehaviour {
    public enum State
    {
       morning,
       lunch,      
       end, 
    }

    FSM<State> _fsm = new FSM<State>();
    void Start()
    {
        State[] states = (State[])Enum.GetValues(typeof(State));
        foreach (State s in states)
        {
            _fsm.addState(s);
            Debug.Log("add state " + s.ToString());
        }

        _fsm.current_state = State.morning;
        Debug.Log("Current State:" + _fsm.current_state.ToString());
        _fsm.addTransition(State.morning, State.lunch, helpTran);
        _fsm.addTransition(State.lunch, State.end, GoHome);
    }

    //[ContextMenu("Make FSM")]
    void Test()
    {
        if (Input.GetKeyDown(KeyCode.A))
        { _fsm.ChangeState(State.end); }

        if (Input.GetKeyDown(KeyCode.D))
        { _fsm.ChangeState(State.lunch); }
    } 
    void Update()
    {
        Test();
    }

    delegate void del();
    del Del;

    Dictionary<string, Callback> transitionTable = new Dictionary<string, Callback>();

    public string transition = "morning->lunch";

    [ContextMenu("TestAdd")]
    void TestAdd()
    {
        transitionTable.Add(transition, helpTran);
    }

    
    /*
        |key                          |value
        |morning->lunch               |helpTran()
        |lunch->evening               |helpEverybodyElse()
        |evening->exitt               |goHome()
        |                             |



    */

    [ContextMenu("Doit")]
    void DoIt()
    { 
        transitionTable[transition]();        
    }
    public void GoHome()
    {
        Debug.Log("Teacher is going home");
    }


    public void helpTran()
    {
        Debug.Log("help tran");
    }
}
