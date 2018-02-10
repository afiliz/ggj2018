using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToastManager : MonoBehaviour 
{
	//public Text endText;
	public bool lost;
	public FirstPersonTriggerManager Goal;

	// Use this for initialization
	void Start () 
	{
		lost = false;
		Goal = GameObject.Find ("PlayerCharacter").GetComponent<FirstPersonTriggerManager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Goal.won) 
		{
			gameObject.GetComponent<Rigidbody> ().Sleep ();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "FloorTrigger") 
		{
			if (!Goal.won)
			{
				lost = true;
			}
		}
	}
}
