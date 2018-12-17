using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerSwitch : MonoBehaviour
{
	public GameObject camera1;
	public GameObject camera2;

	void Start()
	{
		camera1.SetActive(true);
		camera2.SetActive(false);
	}

	void OnGUI()
	{
		if (Input.GetKeyDown(KeyCode.C))
		{
			camera1.SetActive(true);
			camera2.SetActive(false);

		}

		if (Input.GetKeyDown(KeyCode.V))
		{
			camera1.SetActive(false);
			camera2.SetActive(true);
		}

	}
}
