﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {
	public Transform canvas;
	
	void Update ()
    {
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			if (canvas.gameObject.activeInHierarchy == false) 
			{
				canvas.gameObject.SetActive (true);
			}
            else
            {
                canvas.gameObject.SetActive (false); 
            }
            
		} 
		
	}
}
