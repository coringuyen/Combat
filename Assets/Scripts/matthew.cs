using UnityEngine;
using System.Collections;

public class matthew : MonoBehaviour {

	void Awake()
    {
        EventSystem.instance.OnClick += teaching;
    }

    void teaching(GameObject button)
    {
        if(button == this.gameObject)
            print("I'm trying to teach");
    }
}
