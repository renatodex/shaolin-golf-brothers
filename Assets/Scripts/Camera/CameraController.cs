using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject movingPoint;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(this.player.transform.position.x > this.movingPoint.transform.position.x) {
			Vector3 newPosition = this.player.transform.position;
			newPosition.x = this.transform.position.x + 3f;
			newPosition.y = this.transform.position.y;
			newPosition.z = this.transform.position.z;
			//this.transform.position += Vector3.right*8f;
			transform.position = Vector3.Lerp(transform.position, newPosition, 1.7f*Time.deltaTime);
		}
	}
}
