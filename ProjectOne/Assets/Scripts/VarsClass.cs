using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VarsClass : MonoBehaviour
{
    public float floatValue = 5.5f;
    public int intValue = 20;
    public string stringValue = "Bob";
    public int firePower;
    public UnityEvent Event;
    public UnityEvent mouseDownEvent;
    private void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
    }

    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
