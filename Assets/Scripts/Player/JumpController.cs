using UnityEngine;
using System.Collections;

public class JumpController : MonoBehaviour {

	public KeyCode jumpKey;
	public Vector2 jumpForce;

	// Use this for initialization
	public void Start () {
	
	}
	
	// Update is called once per frame
	public void FixedUpdate () {
		Debug.DrawRay(transform.position, Vector3.down*2f, Color.blue, 1);
		if(Input.GetKeyDown(this.jumpKey) && this.isGrounded()){ 
			this.rigidbody2D.AddForce(this.jumpForce);
		}
	}

	private bool isGrounded() {
		if (Physics2D.Raycast(transform.position, Vector3.down, 2f, 1 << LayerMask.NameToLayer("Ground"))) {
			return true;
		} else {
			return false;
		}
	}
}
