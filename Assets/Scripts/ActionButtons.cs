using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActionButtons : MonoBehaviour
{
    GameObject player;
    GameObject enemy;

    void Start ()
    {
        StartCoroutine(attackEnemy());
        StartCoroutine(blockAttack());
	}
    IEnumerator attackEnemy()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            while (Vector3.Distance(player.transform.position, enemy.transform.position) > 0.05f) // checks distance between player and enemy to see if it's greater than .05
            {
                player.transform.position += Vector3.Lerp(player.transform.position, enemy.transform.position, 0.05f); // From to player's position to the enemy position, at .05 speed. 
                //  GetComponent<FSM>().Transition(States;
            }
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            player.transform.position -= Vector3.Lerp(player.transform.position, enemy.transform.position, 0.05f);
        }

        yield return null;

    }

    IEnumerator blockAttack()
    {
        if (Input.GetButton("D"))
        {
            player.transform.position = new Vector3(0, 0.5f, 0);
        }
        yield return null;
    }
}

// Idle to Attack
// IDle to Block
// when release buttons for attack and block, go back to idle. 



//if (Input.anyKeyDown)
//{
//    Debug.Log("some type of key has been pressed");
//    yield return null;
//}