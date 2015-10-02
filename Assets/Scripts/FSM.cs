using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class FSM<T>
{
    //this is the dictionary of transitions that will execute whenever the statemachine transitions
    //key: will be the name of the transition
    //value: will be the delegate that is executed when the transition occurs.
    Dictionary<string, Callback> transitionResult = new Dictionary<string, Callback>();

    public T current_state; // keep track of the current state
    private string key_name; // key for dictionary

    List<T> list_state = new List<T>();

    // add state to the list
    public void addState(T a_state) 
    {
        // this is to check if this element already exist in the list let the user know
        if (list_state.Contains(a_state))
        {
            Debug.Log(a_state.ToString() + " Already exist");
        }

        else // else if it's not then add it
        {
            list_state.Add(a_state);
        }
    }

    // add transition
    public void addTransition(T current, T go, Callback function)
    {
        // if both of the elements are on the list excute code 
        if (list_state.Contains(current) && list_state.Contains(go))
        {
            // create a key for the dictionary
            key_name = current.ToString() + "to" + go.ToString();
            transitionResult.Add(key_name, function);
        }

        else // else if both or one of the elements are not exist on the list let the user know
            Debug.Log("One or both state does not exist");
    }

    //change current_state to state
    public void ChangeState(T state)
    {
        Transition(current_state, state);
    }


    // make a transition between 2 state
    private void Transition(T current, T go)
    {
        // to get the key for this transition do the same thing when creating it 
        key_name = current.ToString() + "to" + go.ToString();

        // checking if the key is exist if it is then the transition is valid
        if (transitionResult.ContainsKey(key_name))
        {
            // excute the delegate
            transitionResult[key_name]();

            // now current state is the state that need to go to
            current_state = go;
            Debug.Log("Current state: " + current_state.ToString());
        }
        else // if it not then let the user know the transition is invalid
        {
            Debug.Log("Invalid transition");
            Debug.Log("Current state: " + current_state.ToString());
        }
    }
    
}
