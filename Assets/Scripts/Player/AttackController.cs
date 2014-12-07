using UnityEngine;
using System.Collections;

public class AttackController : MonoBehaviour {

	public KeyCode attackKey;
	public float attackDistance;


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
			} else {
				attackLine.x -= this.attackDistance;
				Debug.DrawLine(this.transform.position, attackLine, Color.red, 0.2f);
			}

			RaycastHit2D hit = Physics2D.Linecast(transform.position, attackLine, 1 << LayerMask.NameToLayer("Enemy"));
			if(hit) {
				Destroy(hit.transform.gameObject);
				GetComponent<PointsController>().AddPoints(100);
			}
		}
	}
}


//				if (Physics2D.Raycast(transform.position, Vector3.right, attackLine, 1 << LayerMask.NameToLayer("Enemy"))) {
//					
//				}
