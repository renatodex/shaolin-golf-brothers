using UnityEngine;
using System.Collections;

public class AttackController : MonoBehaviour {

	public KeyCode attackKey;
	public float attackDistance;
	private RaycastHit hit;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 attackLine = this.transform.position;

		if(Input.GetKeyDown(this.attackKey)){
			if(GetComponent<MoveController>().direction == "right") {
				attackLine.x += this.attackDistance;
				Debug.DrawLine(this.transform.position, attackLine, Color.red, 0.2f);
//				if(Physics.Raycast(transform.position, attackLine, out this.hit, 1 << LayerMask.NameToLayer("Enemy"))) {
//					Destroy(hit.transform.gameObject);
//				}

			} else {
				attackLine.x -= this.attackDistance;
				Debug.DrawLine(this.transform.position, attackLine, Color.red, 0.2f);
			}
		}
	}
}


//				if (Physics2D.Raycast(transform.position, Vector3.right, attackLine, 1 << LayerMask.NameToLayer("Enemy"))) {
//					
//				}
