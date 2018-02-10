using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	public static DontDestroy instance = null;

	void Start()
	{
		//Causes UI object not to be destroyed when loading a new scene. If you want it to be destroyed, destroy it manually via script.
		DontDestroyOnLoad(this.gameObject);
		if (instance == null) 
		{
			instance = this;
		} 
		else if(instance != this)
		{
			Destroy (gameObject);
		}
	}

	

}
