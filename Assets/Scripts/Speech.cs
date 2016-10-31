using UnityEngine;
using System.Collections;

public class Speech : MonoBehaviour {

	public float rateOfAAHH;
	public AudioClip impact;
	AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		StartCoroutine (makeSound());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator makeSound() {
		audio.volume = 0.1f;
		while(true){
			yield return new WaitForSeconds (2f);
			if (Random.value < rateOfAAHH) {
				
				audio.PlayOneShot(impact, 0.7F);
			}
		}
	}
}
