using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public static GameManager instance = null;


	public Text endText;
	public Text timer;
	public ToastManager toast;
	public FirstPersonTriggerManager goal;

	void OnEnable()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void Awake()
	{
		if (instance == null) 
		{
			instance = this;
		} 
		else if(instance != this)
		{
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);

		toast = GameObject.Find ("toast").GetComponent<ToastManager> ();
		goal = GameObject.Find ("PlayerCharacter").GetComponent<FirstPersonTriggerManager> ();
		endText.text = "";
		timer.text = "";
	}

	// Use this for initialization
	void Start () 
	{
		
	}
		
	// Update is called once per frame
	void Update () 
	{
		if (toast.lost && ! goal.won) 
		{
			endText.text = "You Lose";
			StartCoroutine (Restart ());
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);

		}
		else
		{
			endText.text = "";
			timer.text = "" + (int)goal.timer;
		}
	}

	IEnumerator Restart()
	{
		yield return new WaitForSeconds (1);

	}

	void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		if(toast == null)
		{
			toast = GameObject.Find ("toast").GetComponent<ToastManager> ();
		}
		if (goal == null)
		{
			goal = GameObject.Find ("PlayerCharacter").GetComponent<FirstPersonTriggerManager> ();
		}
		endText.text = "";
		timer.text = "";
		if (scene.name == "Final Level") 
		{
			endText.text = "You Won!";
			StartCoroutine (BackToMenu ());
		}
	}

	IEnumerator BackToMenu()
	{
		yield return new WaitForSeconds (10);
		SceneManager.LoadScene ("Main Menu", LoadSceneMode.Single);
		Cursor.visible = true;
	}
}
