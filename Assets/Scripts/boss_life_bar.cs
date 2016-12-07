using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_life_bar : MonoBehaviour {

	public float boss_hp;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
		Health boss = GameObject.Find ("Boss").GetComponent<Health>();
		boss_hp = boss.health;
		Debug.Log ("Boss HP" + boss_hp);
		gameObject.transform.localScale = new Vector3(boss_hp * 2, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
	
	}
}
