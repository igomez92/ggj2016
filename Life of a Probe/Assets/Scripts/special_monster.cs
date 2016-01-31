﻿using UnityEngine;
using System.Collections;

public class special_monster : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D coll) {
		if (GameInformation.power_up) {
			GetComponent<ParticleSystem> ().Play ();
			Destroy (this.gameObject, .3f);
		} else if (coll.gameObject.name == "Player"){
			GameInformation.player_health--;
		}
	}
}
