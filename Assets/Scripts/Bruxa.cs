using UnityEngine;
using System.Collections;

public class Bruxa : MonoBehaviour {

	private Rigidbody2D myRigidBody;

	public float moveSpeed;
	public Transform[] wayPoint;

	private int objective;

	private float minFade = 0.0f;
	private float maxFade = 1.0f;
	private float durationFade = 1.0f;

	private bool facingRight;


	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();
		objective = 0;
		facingRight = false;
	}

	void FixedUpdate () {
		HandleMovement ();
	}

	void HandleMovement() {
		if (wayPoint [objective].position.x == transform.position.x &&
			wayPoint [objective].position.y == transform.position.y) {

			objective++;

			if (objective == wayPoint.Length) {
				objective = 0;
			}
		}

		Transform target = wayPoint [objective];

		// wayPoint 0 to 1, move
		// wayPoint 1 to 2, blink
		// wayPoint 2 to 3, move
		// wayPoint 3 to 4, blink...
		if (objective % 2 == 1) {
			float step = moveSpeed * Time.fixedDeltaTime;
			transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		} else {
			float blinkSpeed = 999;
			transform.position = Vector3.MoveTowards (transform.position, target.position, blinkSpeed);
		}

		float horizontal = 0;

		if (target.position.x > transform.position.x) {
			horizontal = -1;
		} else {
			horizontal = 1;
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

}
