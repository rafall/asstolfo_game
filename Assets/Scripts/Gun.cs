using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public bool isFiring;

	public Bullet bullet;
	public float bulletSpeed;

	public float timeBetweenShots;
	private float shotCounter;

	public Transform firePoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
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
