using UnityEngine;
using System.Collections;

public class FirstScene : MonoBehaviour {

	public void GoToLevel(int level)
	{
            Application.LoadLevel(level);
	}
	public void Exit() {
		Debug.Log ("Fechando");
		Application.Quit ();
	}
}