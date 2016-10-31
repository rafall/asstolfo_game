using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed;
	public float thrust;
	public Rigidbody2D rb;
	private float lifeTime = 0.3f;
	private Object player;
	// Use this for initialization
	void Awake() {
		rb = GetComponent<Rigidbody2D> ();
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, 
			Vector3.forward);

		transform.rotation = rot;
		//Faz com que ele não faça a rotação no eixo que não precisa
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		transform.Translate (Vector2.up * speed);
		rb.AddForce (transform.up * thrust);
		Destroy (this.gameObject, lifeTime);
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	}
}
