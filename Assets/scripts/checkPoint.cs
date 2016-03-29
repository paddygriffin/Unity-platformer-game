﻿using UnityEngine;
using System.Collections;

public class checkPoint : MonoBehaviour {

	public levelManager levelManage;
	
	// Use this for initialization
	void Start () {
		levelManage = FindObjectOfType<levelManager> (); // finds any object with levelmanager
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		//detects when player enters a triger zone
		if (other.name == "Player") {
			levelManage.currentCheckpoint = gameObject;
			
		}
	}
}
