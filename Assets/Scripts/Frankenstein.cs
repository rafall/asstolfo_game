using UnityEngine;
using System.Collections;

public class Frankenstein : MonoBehaviour {

	//private Rigidbody2D myRigidBody;
	private Transform target;
	public float moveSpeed;

	private bool facingRight;

	// Use this for initialization
	void Start () {
		//myRigidBody = GetComponent<Rigidbody2D> ();
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		facingRight = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		if(target != null)
			HandleMovement ();
	}

	void HandleMovement() {
		float step = moveSpeed * Time.fixedDeltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);

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