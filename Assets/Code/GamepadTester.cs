using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class GamepadTester : MonoBehaviour
{
    private Gamepad gamepad = null;

    private bool ready = false;


    void Awake ()
    {
        gamepad = Gamepad.current;

        if (gamepad != null)
        {
            ready = true;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ready)
        {
            if (gamepad.buttonSouth.wasReleasedThisFrame)
            {
                Debug.Log ("A/X was released.");
            }
        }
    }
}
