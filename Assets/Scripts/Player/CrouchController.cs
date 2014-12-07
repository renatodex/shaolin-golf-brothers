using UnityEngine;
using System.Collections;

public class CrouchController : MonoBehaviour {

	public KeyCode crouchKey;
	public Vector2 crouchingColliderSize;
	public Vector2 crouchingColliderPosition;
	private Vector2 originalColliderSize;
	private Vector2 originalColliderPosition;

	// Use this for initialization
	void Start () {
		this.originalColliderSize = this.GetComponent<BoxCollider2D>().size;
		this.originalColliderPosition = this.GetComponent<BoxCollider2D>().center;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(this.crouchKey)){
			this.GetComponent<MoveController>().allowToMove = false;
			this.setColliderBoudings(this.crouchingColliderSize, this.crouchingColliderPosition);
		} else {
			this.GetComponent<MoveController>().allowToMove = true;
			this.setColliderBoudings(this.originalColliderSize, this.originalColliderPosition);
		}
	}

	private void setColliderBoudings(Vector2 size, Vector2 position) {
		this.GetComponent<BoxCollider2D>().size = size;
		this.GetComponent<BoxCollider2D>().center = position;
	}
}
