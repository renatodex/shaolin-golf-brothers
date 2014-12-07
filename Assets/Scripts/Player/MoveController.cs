using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour
{
	public float maxSpeed, baseSpeed;

	void Start(){
		this.baseSpeed = this.maxSpeed;
	}
	
	void FixedUpdate() {
		float move = Input.GetAxis("Horizontal");	
		updateSpeed(move);
		updateDirection(move);
	}
	
		
	void updateSpeed(float move) {
		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
	}
	
	void updateDirection(float move) {
		if (move > 0) {
			turnRight ();
		} 
		
		if(move < 0){
			turnLeft ();
		}
	}
	
	public void turnRight() {
		turn (180);
	}
	
	public void turnLeft() {
		turn (0);
	}
	
	void turn(int value) {
		transform.eulerAngles = new Vector3(0,value,0);
	}
}

