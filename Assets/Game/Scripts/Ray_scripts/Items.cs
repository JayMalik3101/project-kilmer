﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("player"))
        {
            this.gameObject.SetActive(false);
        }
    }
}