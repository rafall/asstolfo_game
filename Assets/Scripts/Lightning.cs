using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Lightning : MonoBehaviour {

	public float rateOfLightning;
	public AudioClip impact;
	AudioSource audio;
	public GameObject light;

	// Use this for initialization
	void Start () {
		Debug.Log ("Staaart");
		audio = GetComponent<AudioSource>();
		StartCoroutine (makeLight());
	}

	// Update is called once per frame
	void Update () {
	}

	IEnumerator makeLight() {
		// O loop roda durante a cena toda
		while(true){
			yield return new WaitForSeconds (2f);
			if (Random.value < rateOfLightning) {
				// Precisa do for pra fazer o efeito de raio
				for (int i = 0; i < 3; i++) {
					// Cria a luz em um novo GameObject
					GameObject newLight = Instantiate (light);
					audio.PlayOneShot(impact, 0.7F);
					// Destrói pra não ficar lá pra sempre
					Destroy (newLight, .3f);
					yield return new WaitForSeconds (0.1f);
				}
			}
		}
	}


}
