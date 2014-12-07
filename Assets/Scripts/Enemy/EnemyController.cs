using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public float enemyVelocity;
	private GameObject target;

	// Use this for initialization
	public void Start () {
		this.target = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	public void Update () {
		float direction;
		if(this.transform.position.x > targetPositionX()) {
			direction = -1;
		} else {
			direction = 1;
		}

		rigidbody2D.velocity = new Vector2 (direction*(this.enemyVelocity), rigidbody2D.velocity.y);
	}

	private float targetPositionX() {
		return this.target.transform.position.x;
	}
}
