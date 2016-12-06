using UnityEngine;
using System.Collections;

public class BossGun : MonoBehaviour {


	public GameObject EnemyBulletGO;
	public float fireRatep;
	public float fireRatem;

	private float nextFire = 3.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextFire) {
			nextFire = Time.time + Random.Range (fireRatep, fireRatem);
			GameObject boss = GameObject.Find ("Boss");
			Animator boss_atack = boss.GetComponent<Animator> ();
			boss_atack.SetTrigger ("boss_attack");
			Invoke ("FireEnemyBullet", 1f);
		}
	}

	void FireEnemyBullet() {
		GameObject playerShip = GameObject.Find ("Player");

		if (playerShip != null) {
			GameObject bullet = (GameObject)Instantiate (EnemyBulletGO);
			GameObject bullet2 = (GameObject)Instantiate (EnemyBulletGO);
			GameObject bullet3= (GameObject)Instantiate (EnemyBulletGO);


			bullet.transform.position = transform.position;
			bullet2.transform.position = transform.position;
			bullet3.transform.position = transform.position;

			Vector2 direction = playerShip.transform.position - bullet.transform.position;

			Vector2 direction2 = playerShip.transform.position - bullet2.transform.position;

			Vector2 direction3 = playerShip.transform.position - bullet3.transform.position;

			direction2.x = direction2.x + 3;
			direction2.y = direction2.y - 3;

			direction3.x = direction3.x - 3;
			direction3.y = direction3.y - 3;


			bullet.GetComponent<EnemyBullet> ().SetDirection (direction);
			bullet2.GetComponent<EnemyBullet> ().SetDirection (direction2);
			bullet3.GetComponent<EnemyBullet> ().SetDirection (direction3);
		}
	}
}
