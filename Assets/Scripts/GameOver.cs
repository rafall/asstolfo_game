using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (GoToTitle());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator GoToTitle() {
		yield return new WaitForSeconds (5f);
		Application.LoadLevel("Transition1");
	}
}
