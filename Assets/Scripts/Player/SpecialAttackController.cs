using UnityEngine;
using System.Collections;

public class SpecialAttackController : MonoBehaviour {

	public GameObject specialWordThis;
	public GameObject specialWordIs;
	public GameObject specialWordGolf;


	// Use this for initialization
	void Start () {
		Debug.Log (GameObject.Find ("SpecialThis"));
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)) {
			if(GetComponent<GaugeBarController>().gaugeBarReady()) {
				StartCoroutine("useSpecial");
			}
		}
	}

	IEnumerator useSpecial() {
		float actualTimeScale = Time.timeScale;

		GetComponent<GaugeBarController>().resetGaugeBar();

		Time.timeScale = 0.1f;

		yield return new WaitForSeconds(0.1f);

		GameObject label = (GameObject) Instantiate(this.specialWordThis);

		yield return new WaitForSeconds(0.3f);


		GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
		foreach(GameObject enemy in enemies) {
			Destroy(enemy);
		}

		Destroy(label);

		Time.timeScale = actualTimeScale;

		yield return null;

	}
}
