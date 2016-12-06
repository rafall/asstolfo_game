using UnityEngine;
using System.Collections;

public class Caveira : MonoBehaviour {

	private Rigidbody2D myRigidBody;

	private bool facingRight;
	public GameObject EnemyBulletGO;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		StartCoroutine (FireEnemyBullet());
		facingRight = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject != null)
			HandleMovement ();
	}

	void HandleMovement() {

		//Flip (horizontal);
	}

	private void Flip(float horizontal) {
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight) {
			facingRight = !facingRight;

			Vector2 spriteScale = transform.localScale;

			spriteScale.x *= -1;

			transform.localScale = spriteScale;
		}
	}

	IEnumerator FireEnemyBullet() {
		GameObject player = GameObject.Find ("Player");
		if (player != null) {
			while (true) {
				GameObject bullet = (GameObject)Instantiate (EnemyBulletGO);

				Vector3 direction = player.transform.position - bullet.transform.position;

				bullet.GetComponent<EnemyBullet> ().SetDirection (direction);
				yield return new WaitForSeconds (1.3f);
			}
		}
	}
}
