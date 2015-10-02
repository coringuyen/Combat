using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class FSM<T>
{
    // key : transition create
    // value : excute delegate
    Dictionary<string, CallBack> transitionTable = new Dictionary<string, CallBack>();

    List<T> list_state = new List<T>();
    public T current_state;
    private string key_name;
    // add state to the list
    public void addState(T a_state) 
    {
        // this is to check if this element already exist in the list if it is let the user know
        if (list_state.Contains(a_state))
        {
            Debug.Log(a_state.ToString() + " Already exist");
        }

        else // else if it's not then add it
        {
            list_state.Add(a_state);
        }
    }

    // create transition
    public void addTransition(T current, T go, CallBack function)
    {
        // if both of the elements are on the list then create a key then add them to a dictionary with the value
        if (list_state.Contains(current) && list_state.Contains(go))
        {
            key_name = current.ToString() + " to " + go.ToString();
            transitionTable.Add(key_name, function);
        }
        else // else if both or one of the elements are not exist on the list let the user know
            Debug.Log("One or both state does not exist");
    }

    // change current state to state
    public void changeTo(T state)
    {
        Transition(current_state, state);
    }

    // make a transition between 2 state
    private void Transition(T current, T go)
    {
        // get the key by doing the same way when creating it
        key_name = current.ToString() + " to " + go.ToString();

        // if the key is exist then execute the delegate of that key
        if (transitionTable.ContainsKey(key_name))
        {
            transitionTable[key_name]();

            // now current state is the state that need to go to
            current_state = go;
            Debug.Log("Current state: " + current_state.ToString());
        }
        else // if not then let the user know that this transition is invalid
        {
            Debug.Log("Invalid Transition: " + key_name);
            Debug.Log("Current state: " + current_state.ToString());
        }

    }
}
