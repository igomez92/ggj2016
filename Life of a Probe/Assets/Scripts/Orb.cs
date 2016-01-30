﻿using UnityEngine;
using System.Collections;


public class Orb : MonoBehaviour {
	public float lifespan;

	// Use this for initialization
	void Start () {
		
	}
		
	// Update is called once per frame
	void Update () {
		lifespan -= Time.deltaTime;
		if (lifespan < 0)
			Destroy (this.gameObject);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log (coll.gameObject.name);
		if (coll.gameObject.name == "Player") {
			GameInformation.orb_count++;
			GameInformation.special_count--;
			GameInformation.timer = 0;
			Destroy (this.gameObject);
		}
	}
}


	

	