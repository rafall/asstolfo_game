using UnityEngine;
using System.Collections;

public class ColliderTester : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log (gameObject.name + " foi trigado por " + other.gameObject.name);

		if (gameObject.tag == "EnemyProjectile" &&
			other.gameObject.tag == "Player") {

			causeDamage (gameObject, other.gameObject);
		} else if(gameObject.tag == "PlayerProjectile" &&
			other.gameObject.tag == "Enemy") {

			causeDamage (gameObject, other.gameObject);
		} else if(gameObject.tag == "Player" &&
			other.gameObject.tag == "Enemy") {

			// invert
			causeDamage (other.gameObject, gameObject);
		}
	}

	void causeDamage(GameObject dealer, GameObject target) {
		Debug.Log ("Dano causado");
		// assume these objects have the scripts Damage and Health
		Damage scriptDamage = dealer.GetComponent<Damage> ();
		Health healthScript = target.GetComponent<Health> ();

		healthScript.health -= scriptDamage.damage;
		Debug.Log ("Dano causado " + scriptDamage.damage);
	}
}
