using UnityEngine;
using System.Collections;

public class paul : MonoBehaviour {

    void Awake()
    {
        EventSystem.instance.OnClick += struggling;
    }

    void struggling(GameObject button)
    {
        if(button == this.gameObject)
            print("I'm struggling to understand");
    }
}
