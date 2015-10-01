using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class FSM<T>
{
    // store delegate
    Dictionary<string, System.Delegate> functions_delegate = new Dictionary<string, System.Delegate>();
<<<<<<< HEAD
    
=======
   
    delegate void Delegate_of_delegate();
    //Delegate_of_delegate delegate_of_delegate;

>>>>>>> origin/master
    List<T> list_state = new List<T>();
    int count = 0; // count the item that got add to the list

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
            count += 1;
            list_state.Add(a_state);
            Debug.Log(count);
        }
    }

<<<<<<< HEAD
    // adding delegate to store dictionary 
    public void addDelegate(string name_delegate, System.Delegate a_delegate)
    {
        // check if this delegate exist 
        if(functions_delegate.ContainsValue(a_delegate))
=======
    public void addDelegate(string name_delegate, System.Delegate a_delegate)
    {
        // check if this delegate exist
        if (functions_delegate.ContainsValue(a_delegate))
>>>>>>> origin/master
        {
            Debug.Log(a_delegate.ToString() + "Already Exist");
        }

        else
            functions_delegate.Add(name_delegate, a_delegate);
<<<<<<< HEAD
    }
    
    // make a transition between 2 state
    public void makeTransition(T current_state, T goto_state, System.Delegate a_delegate) 
=======

    }


    //static void addFunctions(Delegate_of_delegate delegates)
    //{
        
    //}

    // make a transition between 2 state
    public void makeTransition(T current_state, T goto_state)
>>>>>>> origin/master
    {
        // this is to check if both of the elements are on the list
        
        if (list_state.Contains(current_state) && list_state.Contains(goto_state) && functions_delegate.ContainsValue(a_delegate)) 
        {
            // now current state is the state that need to go to
            current_state = goto_state;
            Debug.Log("Current state: " + current_state.ToString());

<<<<<<< HEAD
            //don't know how to use this a_delegate variable to use the user delegate, run out of time 
            // Will figure out after submit the project
           
=======
            //delegate_of_delegate();
            //don't know how to use this a_delegate variable to use the user delegate, run out of time
            // will figure out after submit the project
>>>>>>> origin/master
        }

        else // else if both or one of the elements are not exist on the list let the user know
            Debug.Log("One or both state does not exist");
    }
    
}
