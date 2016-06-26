using UnityEngine;
using System.Collections;

public class PedestrianSpawner : MonoBehaviour {
	public float minSpawn = 2f;
	public float maxSpawn = 5f;
	public static float adUpgrade = 1f;

	public GameObject[] pedestrians;
	public int rotation;


	void Awake () {
		if (this.gameObject.transform.position.x < 0) {
			rotation = 0;
		} 
		else {
			rotation = 180;
		}
	
	}

	void Start(){
		StartCoroutine ("SpawnInterval");
	}

	void SpawnPedestrian(){
		Instantiate(pedestrians[Random.Range(0, pedestrians.Length)], this.gameObject.transform.position, Quaternion.Euler(0, rotation, 0));
	}

	private IEnumerator SpawnInterval(){
		yield return new WaitForSeconds (Random.Range(0f, 2f));

		while (true) {
			SpawnPedestrian ();
			yield return new WaitForSeconds(Random.Range((minSpawn * adUpgrade), (maxSpawn * adUpgrade)));
		}
	}
}
