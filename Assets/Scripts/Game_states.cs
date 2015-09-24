using UnityEngine;
using System.Collections;

public class Game_states : MonoBehaviour {

	enum Game_States { Init, Game_Run, Pause, Exit }
    FSM<Game_States> Game_Menu = new FSM<Game_States>();

    void Start()
    {
        Game_Menu.addState(Game_States.Init);
        Game_Menu.addState(Game_States.Game_Run);
        Game_Menu.addState(Game_States.Pause);
        Game_Menu.addState(Game_States.Exit);

        //Game_Menu.makeTransition(Game_States.Init, Game_States.Game_Run);
    }
}
