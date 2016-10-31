using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public float Speed = 0f;
	public bool isFiring;
	public Bullet bullet;
	public float bulletSpeed;
	public float timeBetweenShots;
	public int direction = 0;

	private float movex = 0f;
	private float movey = 0f;

	private float shotCounter;


	public Transform firePoint;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void FixedUpdate () {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);

		if(Input.GetMouseButtonDown(0)) {
			Debug.Log ("Clicou");
			isFiring = true;
		}
		if(Input.GetMouseButtonUp(0)) {
			isFiring = false;
		}

		if (isFiring) {
			Debug.Log ("Atiraaaaa");
			shotCounter -= Time.deltaTime;
			if (shotCounter <= 0) {
				shotCounter = timeBetweenShots;
				Instantiate (bullet, firePoint.position, firePoint.rotation);
				Bullet newBullet = Instantiate (bullet, firePoint.position, firePoint.rotation) as Bullet;
				newBullet.speed = bulletSpeed;
			}

		} else {
			shotCounter = 0;

		}
	}
}
