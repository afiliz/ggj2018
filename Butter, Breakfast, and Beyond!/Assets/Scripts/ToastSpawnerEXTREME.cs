using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastSpawnerEXTREME : MonoBehaviour {

	public Transform toast;

	// Use this for initialization
	void Start () 
	{
		toast = GameObject.Find ("toast").GetComponent<Transform> ();

		for (int i = 0; i < 100; i++) 
		{
			float xRange = Random.Range (-5f, 5f);
			float yRange = Random.Range (10, 20f);
			float zRange = Random.Range (-5f, 5f);

			Instantiate (toast, gameObject.transform.position + new Vector3 (xRange, yRange, zRange), 
				Random.rotation);		
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		float xRange = Random.Range (-5f, 5f);
		float yRange = Random.Range (10, 20f);
		float zRange = Random.Range (-5f, 5f);

		Instantiate (toast, gameObject.transform.position + new Vector3 (xRange, yRange, zRange), 
			Random.rotation);
	}
}
