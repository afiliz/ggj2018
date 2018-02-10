using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class FirstPersonTriggerManager : MonoBehaviour 
{
	public ToastManager toast;
	public bool won;
	public float timer;

	// Use this for initialization
	void Start () 
	{
		//GetComponentInChildren<HandController> ().enabled = false;
		toast = GameObject.Find ("toast").GetComponent<ToastManager> ();
		won = false;
		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Goal") 
		{
			if (!toast.lost) 
			{
				won = true;
				//GetComponent<RigidbodyFirstPersonController> ().enabled = false;
				//GetComponentInChildren<HandController> ().enabled = true;
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
