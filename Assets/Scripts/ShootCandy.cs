using UnityEngine;
using System.Collections;

public class ShootCandy : MonoBehaviour {

	public bool isFiring;
	public Bullet bullet;
	public float bulletSpeed;
	public float timeBetweenShots;
	public int direction = 0;
	public Transform firePoint;

	private float movex = 0f;
	private float movey = 0f;

	private float shotCounter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetMouseButton(0)) {
			isFiring = true;
		} else {
			isFiring = false;
		}

		shotCounter -= Time.deltaTime;

		if (isFiring) {
			if (shotCounter <= 0) {
				shotCounter = timeBetweenShots;
				
				Bullet newBullet = Instantiate (bullet, firePoint.position, firePoint.rotation) as Bullet;
				newBullet.speed = bulletSpeed;
			}

		} else {
			shotCounter = 0;

		}
	}
}
