﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_life : MonoBehaviour {
	public float boss_hp;
	private float boss_max_hp = 1000;
	private float life_bar_x_position;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		Health boss = GameObject.Find ("Boss").GetComponent<Health>();
		boss_hp = boss.health;
		//Debug.Log ("Boss HP" + boss_hp);
		RectTransform rect = gameObject.GetComponent<RectTransform> ();
		rect.sizeDelta = new Vector2 (boss_hp * 0.2f, 20);

		life_bar_x_position = (boss_hp - boss_max_hp) * 0.1f;
		Debug.Log ("Position x: " + life_bar_x_position);
		rect.anchoredPosition = new Vector2 (life_bar_x_position, rect.anchoredPosition.y);	
	}
}
