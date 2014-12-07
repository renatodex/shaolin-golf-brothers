using UnityEngine;
using System.Collections;

public class GaugeBarUIController : MonoBehaviour {

	public float gaugeBarFullWidth;
	private float maxPoints; 

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.Find("Player");
		this.maxPoints = player.GetComponent<GaugeBarController>().maximumGaugeLevel;
		this.gaugeBarFullWidth = this.GetComponent<UISprite>().width;
		this.updateWidthByPoints(0f);
	}

	public float pointsToWidth(float points) {
		return this.gaugeBarFullWidth*points/this.maxPoints;
	}
	
	public void updateWidthByPoints(float points) {
		float width = this.pointsToWidth(points);
		GetComponent<UISprite>().width = (int)Mathf.Ceil(width);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
