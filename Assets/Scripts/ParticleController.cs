using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour {

	public ParticleSystem particle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (particle.IsAlive () == false) {
			
			if (particle.gameObject.name == "DavidSparks") {

				gameObject.SetActive (false);

			} else {
				
				Destroy (gameObject);

			}

		}
	}
}
