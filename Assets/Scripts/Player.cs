using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody2D myRigidBody;
	private Animator animator;

	private bool facingRight;
	public bool hasKey;
	public float moveSpeed;
	public float minSpeed;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();

		facingRight = false;

	}

	void FixedUpdate () {
		HandleMovement ();
	}

	void HandleMovement() {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		if (vertical >= minSpeed || vertical <= -minSpeed) {
			myRigidBody.velocity = new Vector2 (
				vertical * moveSpeed,
				myRigidBody.velocity.y);
		} else {
			myRigidBody.velocity = new Vector2 (
				0f,
				myRigidBody.velocity.y);
		}

		if (horizontal >= minSpeed || horizontal <= -minSpeed) {
			myRigidBody.velocity = new Vector2(
				horizontal * moveSpeed,
				myRigidBody.velocity.x);
		} else {
			myRigidBody.velocity = new Vector2 (
				0f,
				myRigidBody.velocity.x);
		}

		if (vertical >= minSpeed || vertical <= -minSpeed ||
		    horizontal >= minSpeed || horizontal <= -minSpeed) {

			animator.SetBool ("move", true);
		} else {
			animator.SetBool ("move", false);
		}

		Flip (horizontal);
	}

	private void Flip(float horizontal) {
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight) {
			facingRight = !facingRight;

			Vector3 spriteScale = transform.localScale;

			spriteScale.x *= -1;

			transform.localScale = spriteScale;
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		Debug.Log (gameObject.name + " was triggered by " + col.gameObject.name);
	}
}

