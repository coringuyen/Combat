using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class FSM<T>
{
    // add functions user want to happen between the states 
    delegate void functions_todothing();

    List<T> list_state = new List<T>();
    int count = 0; // count the item that got add to the list

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
            count += 1;
            list_state.Add(a_state);
            Debug.Log(count);
        }
    }

    // make a transition between 2 state
    public void makeTransition(T current_state, T goto_state) 
    {
        // this is to check if both of the elements are on the list
        if (list_state.Contains(current_state) && list_state.Contains(goto_state)) 
        {
            // now current state is the state that need to go to
            current_state = goto_state; 

            // need to run funcstions
        }

        else // else if both or one of the elements are not exist on the list let the user know
            Debug.Log("One or both state does not exist");
    }
    
}
