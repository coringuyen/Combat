using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Action : MonoBehaviour
{
    public GameObject players;
    public Button Play;    
    int currentHealth, damage, startingHealth = 100;

	void Start ()
    {

    }

    void Init(GameObject player)
    {
        Play.gameObject.SetActive(true); // UI button on the screen disappear
        Instantiate(player, new Vector3(0, 0.5f, 0), new Quaternion(0,0,0,0));
    }

    void Idle(GameObject player)
    {
        player.transform.position = new Vector3(0, 0.5f, 0); // setting the player's position
    }

    public void Attack(GameObject player)
    {
        damage = 10;
        currentHealth -= damage;
        Debug.Log("Hit");
    }

   public void Block(GameObject player)
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            damage = 0;
            currentHealth -= damage;
            Debug.Log("Block DA STUFF!");
        }
    }

    public void Death(GameObject player)
    {
        currentHealth = 0;
        Debug.Log("Dead person");
    }
}




//public GameObject enemy; 
//startingHealth = 100;

//Init(players);
//Idle(players);
//Attack(players);
//Block(players);
//Death(players);