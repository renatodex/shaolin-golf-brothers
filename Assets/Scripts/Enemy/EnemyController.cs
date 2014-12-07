using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	public float enemyVelocity;
	private GameObject target;
	public float killDistance;

	// Use this for initialization
	public void Start () {
		this.target = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	public void Update () {
		Vector3 facing = new Vector3(0f,0f,0f);
		Vector3 attackLine;
		float direction;

		if(this.transform.position.x > targetPositionX()) {
			direction = -1;
			facing = Vector3.left;
		} else {
			direction = 1;
			facing = Vector3.right;
		}

		attackLine = this.transform.position+facing*this.killDistance;

		Debug.DrawLine(this.transform.position, attackLine, Color.yellow, 0.2f);

		RaycastHit2D hit = Physics2D.Linecast(this.transform.position, attackLine, 1 << LayerMask.NameToLayer("Player"));
		if(hit) {
			if(hit.collider.tag == "Player") {
				Destroy(hit.collider.gameObject);
			}
		}

		rigidbody2D.velocity = new Vector2 (direction*(this.enemyVelocity), rigidbody2D.velocity.y);
	}

	private float targetPositionX() {
		return this.target.transform.position.x;
	}
}
