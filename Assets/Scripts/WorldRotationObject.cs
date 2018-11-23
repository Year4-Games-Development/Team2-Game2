﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldRotationObject : MonoBehaviour {
    Quaternion worldRotation;

	// Use this for initialization
	void Start () {
        worldRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = worldRotation;
	}
}
