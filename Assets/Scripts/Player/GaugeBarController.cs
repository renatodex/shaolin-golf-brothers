using UnityEngine;
using System.Collections;

public class GaugeBarController : MonoBehaviour {

	public int maximumGaugeLevel;
	public int actualGaugeLevel;
	
	public void AddGaugeBar(int value) {
		if(this.actualGaugeLevel+value < this.maximumGaugeLevel) {
			this.actualGaugeLevel += value;

			GameObject gaugeBarUI = GameObject.Find ("GaugeBarUI");
			gaugeBarUI.GetComponent<GaugeBarUIController>().updateWidthByPoints(this.actualGaugeLevel);
		}
	}
}
