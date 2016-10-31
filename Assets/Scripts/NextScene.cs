using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {
	public int nextLevel;
	// Use this for initialization
	void Start () {
		StartCoroutine (GoToNext());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator GoToNext() {
		yield return new WaitForSeconds (2f);
		Application.LoadLevel(nextLevel);
	}
}
