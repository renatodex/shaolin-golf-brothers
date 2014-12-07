using UnityEngine;
using System.Collections;

public class AttackController : MonoBehaviour {

	public KeyCode attackKey;
	public float attackDistance;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 attackLine = this.transform.position;

		if(Input.GetKeyDown(this.attackKey)){

			if(GetComponent<MoveController>().direction == "right") {
				attackLine.x += this.attackDistance;
				Debug.DrawLine(this.transform.position, attackLine, Color.red, 0.2f);
			} else {
				attackLine.x -= this.attackDistance;
				Debug.DrawLine(this.transform.position, attackLine, Color.red, 0.2f);
			}
		}
	}
}
