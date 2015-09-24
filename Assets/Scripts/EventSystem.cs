using UnityEngine;
using System.Collections;

public class EventSystem : MonoBehaviour
{
    public delegate void ClickEvent(GameObject button);
    public delegate void PauseEvent();

    public event PauseEvent OnPause;
    public event ClickEvent OnClick;

    static private EventSystem _instance;
    static public EventSystem instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<EventSystem>();
            return _instance;
        }
    }

   

    void Update()
    {
        //Create the origin of the ray
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // raycast hit
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 100))
        {
            //if we click
            if(Input.GetMouseButton(0))
            {
                Debug.Log("Event happen on " + hit.transform.name);
                // notify of the event!
                OnClick(hit.transform.gameObject);
            }
        }
    }

}
