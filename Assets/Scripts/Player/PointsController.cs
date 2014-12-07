using UnityEngine;
using System.Collections;

public class PointsController : MonoBehaviour {

	int points;

	// Use this for initialization
	public void Start () {
		this.points = 0;	
	}

	public void AddPoints(int points) {
		this.points += points;
		this.updateLabel(this.points);
	}

	private void updateLabel(int points) {
		GameObject pointsLabel = GameObject.Find("PointsLabel");
		pointsLabel.GetComponent<UILabel>().text = points.ToString();
	}
}
