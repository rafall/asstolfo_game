using UnityEngine;
using System.Collections;

public class Fantasma : MonoBehaviour {

	private Rigidbody2D myRigidBody;

	public float moveSpeed;
	public Transform[] wayPoint;

	private int objective;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();

		objective = 0;
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

		float step = moveSpeed * Time.fixedDeltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position, step);
	}
		
}
