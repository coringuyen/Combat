using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Factory : MonoBehaviour
{
    List<GameObject> Units = new List<GameObject>();
    float delay = 5;
    public float time = 0;

	public void MakeUnit(GameObject unit)
    {
        GameObject Unit;
        time += Time.deltaTime;  

        if(time > delay)
        {
            time = 0;
            Unit = Instantiate(unit) as GameObject;
            Unit.transform.position = new Vector3(Random.Range(10.0f,-10.0f), 2f, Random.Range(10.0f, -10.0f));
            Units.Add(Unit);
        }
    }
}
