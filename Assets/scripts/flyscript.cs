﻿using UnityEngine;
using System.Collections;

public class flyscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (Vector3.back * Time.deltaTime);
		transform.Translate(Vector3.left*Time.deltaTime*7,Space.World);
	
	}
}
