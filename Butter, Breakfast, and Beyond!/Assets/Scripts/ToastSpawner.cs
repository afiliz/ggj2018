using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class ToastSpawner : MonoBehaviour {

	public Transform toast;
	public Transform bigToast;
	public Transform spawn;

	// Use this for initialization
	void Start () {
		Debug.Log ("Starting spawner");
		StartCoroutine (waitToSpawn ());
	}

	IEnumerator waitToSpawn(){
		Debug.Log ("Waiting for toast drop");
		//yield return new WaitForSeconds(2);

		for (int i = 0; i < 60; i++) {
			Debug.Log ("3 seconds before drop");
			yield return new WaitForSeconds (5);
			Instantiate (toast, spawn.position, Random.rotation);
			Debug.Log ("Spawned toast");
			Cursor.visible = true;
		}
		for (int i = 0; i < 5; i++) {
			Debug.Log ("Waiting 3 seconds for the big load");
			yield return new WaitForSeconds (5);
			Instantiate (bigToast, spawn.position, spawn.rotation);
		}
		Debug.Log ("Waiting 3 seconds for the big load");
		yield return new WaitForSeconds (2);
		Instantiate (bigToast, spawn.position, spawn.rotation);
	}
}
