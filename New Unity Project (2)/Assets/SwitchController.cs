using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchController : MonoBehaviour
{

    public UnityEvent onSwitchOn;
    public UnityEvent onSwitchOff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(" y : " + transform.rotation.y);
        if (transform.rotation.y > 0.45)
            onSwitchOff.Invoke();
        else
            onSwitchOn.Invoke();
    }
}
