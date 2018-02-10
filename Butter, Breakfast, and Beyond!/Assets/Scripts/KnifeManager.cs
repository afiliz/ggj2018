using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KnifeManager : MonoBehaviour {

	bool haveJam = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Target") {
			haveJam = true;
		}
		if (other.name == "toast") {
			if (haveJam) {
				StartCoroutine (WasteTime (other));
			}
		}
	}

		IEnumerator WasteTime(Collider other)
		{
			yield return new WaitForSeconds (1);
			SceneManager.LoadScene (other.gameObject.GetComponent<Goal> ().nextLevel, LoadSceneMode.Single);
		}
}
