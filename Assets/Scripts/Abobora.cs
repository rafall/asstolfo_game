using UnityEngine;
using System.Collections;

public class Abobora : MonoBehaviour {

	private Rigidbody2D myRigidBody;

	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private float radius;

	private bool facingRight;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();

		facingRight = true;
	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate () {
		HandleMovement ();
	}

	void HandleMovement() {
		float t = Time.realtimeSinceStartup;

		myRigidBody.velocity = new Vector2 (
			radius * Mathf.Sin(t * moveSpeed),
			myRigidBody.velocity.y);

		myRigidBody.velocity = new Vector2 (
			radius * Mathf.Cos(t * moveSpeed),
			myRigidBody.velocity.x);

		Flip (myRigidBody.velocity.x);
	}

	private void Flip(float horizontal) {
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight) {
			facingRight = !facingRight;

			Vector3 spriteScale = transform.localScale;

			spriteScale.x *= -1;

			transform.localScale = spriteScale;
		}
	}
}
