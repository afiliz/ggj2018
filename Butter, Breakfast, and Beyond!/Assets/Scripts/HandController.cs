using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HandController : MonoBehaviour
{
	bool haveJam;

	void Start()
	{
		haveJam = false;
	}

	void FixedUpdate()
	{
		float moveX = Input.GetAxis ("Mouse X") * .1f;
		float moveY = Input.GetAxis ("Mouse Y") * .1f;
		float moveZ = (Input.GetAxis ("Fire1") - Input.GetAxis ("Fire2")) * .05f;

		Vector3 movement = new Vector3 (moveX, 0, moveY);
		gameObject.transform.position = new Vector3 (gameObject.transform.position.x + moveX, gameObject.transform.position.y + moveZ, gameObject.transform.position.z + moveY);
	}
}