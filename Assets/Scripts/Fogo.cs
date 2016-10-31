using UnityEngine;
using System.Collections;

public class Fogo : MonoBehaviour {

	private bool facingRight;

	// Use this for initialization
	void Start () {
		facingRight = false;
	}

	void FixedUpdate () {
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

}
