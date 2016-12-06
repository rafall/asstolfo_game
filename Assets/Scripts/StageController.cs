using UnityEngine;
using System.Collections;

public class StageController : MonoBehaviour {

	public int numOfMonsters;
	public GameObject key;
	public GameObject menu;
	private GameObject newMenu;
	private bool pause;

	// Use this for initialization
	void Start () {
		pause = false;
	}

	// Update is called once per frame
	void Update () {
		if (numOfMonsters == 0) {
			numOfMonsters = 100;
			Instantiate (key);
			GameObject newKey = Instantiate (key);
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (pause) {
				Destroy (newMenu, 0f);
				Time.timeScale = 1;
				Debug.Log ("Despause");
			} else {
				newMenu = Instantiate (menu);
				Time.timeScale = 0;
				Debug.Log ("Pause");
			}

			Debug.Log ("Clicou ESC");
			pause = !pause;
		}


	}


}
