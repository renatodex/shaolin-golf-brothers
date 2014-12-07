using UnityEngine;
using System.Collections;

public class GaugeBarController : MonoBehaviour {

	public int maximumGaugeLevel;
	public int actualGaugeLevel;
	
	public void AddGaugeBar(int value) {
		if(this.actualGaugeLevel+value < this.maximumGaugeLevel) {
			this.actualGaugeLevel += value;
		} else {
			this.actualGaugeLevel = this.maximumGaugeLevel;
		}

		GameObject gaugeBarUI = GameObject.Find ("GaugeBarUI");
		gaugeBarUI.GetComponent<GaugeBarUIController>().updateWidthByPoints(this.actualGaugeLevel);
	}

	public bool gaugeBarReady() {
		if(this.actualGaugeLevel == this.maximumGaugeLevel) {
			return true;
		} else {
			return false;
		}
	}

	public void resetGaugeBar() {
		this.actualGaugeLevel = 0;
		GameObject gaugeBarUI = GameObject.Find ("GaugeBarUI");
		gaugeBarUI.GetComponent<GaugeBarUIController>().updateWidthByPoints(0f);
	}
}
