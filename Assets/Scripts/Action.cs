using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Action : MonoBehaviour
{
    public GameObject players;
    //public GameObject enemy;
    public Button Play;
    int startingHealth = 100;
    int currentHealth;
    int damage;
    bool isDead; // enemy is dead
	void Start ()
    {
        currentHealth = startingHealth;
        //Init(players);
        //Idle(players);
        //Attack(players);
        //Block(players);
        Death(players);
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
        print("Hit");
    }

   public void Block(GameObject player)
    {
        damage = 0;
        currentHealth -= damage;
        print("Block DA STUFF!");
    }

    public void Death(GameObject player)
    {
        currentHealth = 0;
        print("Dead person");
    }
}
