using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour
{
	public float maxSpeed, baseSpeed;
	public bool allowToMove;
	public string direction;

	public void Start(){
		this.baseSpeed = this.maxSpeed;
	}
	
	public void Update() {
		float move = Input.GetAxis("Horizontal");	

		if(this.allowToMove) {
			this.updateSpeed(move);
			this.updateDirection(move);
		}
	}

	private void updateSpeed(float move) {
		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
	}
	
	private void updateDirection(float move) {
		if (move > 0) {
			turnRight ();
		}
		
		if(move < 0){
			turnLeft ();
		}
	}
	
	private void turnRight() {
		this.direction = "right";
		turn (180);
	}
	
	private void turnLeft() {
		this.direction = "left";
		turn (0);
	}
	
	void turn(int value) {
		transform.eulerAngles = new Vector3(0,value,0);
	}
}

