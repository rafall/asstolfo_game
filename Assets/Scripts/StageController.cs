using UnityEngine;
using System.Collections;

public class StageController : MonoBehaviour {

	public int numOfMonsters;
	public GameObject key;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (numOfMonsters == 0) {
			numOfMonsters = 1;
			Instantiate (key);
			GameObject newKey = Instantiate (key);
		}

	}


}
