using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Debug.Log ("Pegou a Chave");
			other.gameObject.GetComponent<Player> ().hasKey = true;
			Destroy (gameObject, 0f);
		}
	}
}
