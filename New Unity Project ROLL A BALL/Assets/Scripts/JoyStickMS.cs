﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

    protected Joystick joystick;
    protected JoyButton joybutton;

    protected bool jump;

	// Use this for initialization
	void Start () {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<JoyButton>(); 
		}
	
	// Update is called once per frame
	void Update () {

        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 100f,
                                         rigidbody.velocity.y,
                                         joystick.Vertical * 100f);

        if(!jump && joybutton.Pressed)
        {
            jump = true;
            rigidbody.velocity += Vector3.up * 100f;
        }

        if (jump && !joybutton.Pressed) ;
        {
            jump = false;
        }
	}
}
