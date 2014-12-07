using UnityEngine;
using System.Collections;

public class SpawnerController : MonoBehaviour {

	public GameObject enemy1;
	public float enemyVelocity;

	// Use this for initialization
	public void Start () {
		//StartCoroutine("spawner");
		Invoke("enemy1Spawn", 0.5f);
	}

	IEnumerator spawner() {
		while(true) {
			yield return new WaitForSeconds(Random.Range(0f, 4f));

			this.spawnEnemy(this.enemy1);

			yield return null;
		}
	}

	private void enemy1Spawn() {
		this.spawnEnemy(this.enemy1);
	}

	private void spawnEnemy(GameObject enemy) {
		GameObject instantiatedEnemy = (GameObject) Instantiate(enemy);
		instantiatedEnemy.transform.position = transform.position;
	}

	// Update is called once per frame
	public void Update () {
	
	}
}
