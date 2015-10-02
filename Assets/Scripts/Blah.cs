using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Blah : MonoBehaviour
{
    public string a_name;

    void Update()
    {
        gameObject.transform.name = a_name;
    }
	
}
