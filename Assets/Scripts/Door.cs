﻿using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public int nextLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Player")
		if(other.gameObject.GetComponent<Player> ().hasKey)
			Application.LoadLevel(nextLevel);
		
	}
}
