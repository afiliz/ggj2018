using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfPopulator : MonoBehaviour {

	public Transform[] items;

	void Start () 
	{
		items = new Transform[4];
		items [0] = GameObject.Find ("SixPack").transform;
		items [1] = GameObject.Find ("Bottle").transform;
		items [2] = GameObject.Find ("Box").transform;
		items [3] = GameObject.Find ("Chips").transform;


		float numberSpawned = 0f;

		for (int i = 0; i < 3; i++) 
		{
			int itemNumber = (int)Random.Range (0f, 3.4f);
			for (int j = 0; j < 4; j++) 
			{
				Instantiate (items [itemNumber], transform.position + new Vector3(numberSpawned, 0, 0), items[itemNumber].rotation);
				numberSpawned -= 0.3f;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
