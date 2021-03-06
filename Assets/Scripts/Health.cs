﻿using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health;
	private GameObject go;
	// Use this for initialization
	void Start () {

	}

	void FixedUpdate() {
		
		if (health <= 0) {
			Debug.Log (gameObject.name + " is DEAD");
			if (gameObject.name == "Player") {
				Application.LoadLevel("GameOver");
			}
			if (gameObject.name == "Boss") {
				Application.LoadLevel("End");
			}
			go = GameObject.FindGameObjectWithTag ("Stage");
			if (go != null) {
				int num = go.GetComponent<StageController>().numOfMonsters;
				num -= 1;
				go.GetComponent<StageController> ().numOfMonsters = num;
			}

			if(gameObject != null)
				Destroy (gameObject, 0f);

		}
	}
}
