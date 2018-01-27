using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity_Limiter : MonoBehaviour {

	public float velocityLimit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rb = gameObject.GetComponent<Rigidbody> ();


		if (rb.velocity.magnitude > velocityLimit) {

			rb.velocity = Vector3.ClampMagnitude (rb.velocity, velocityLimit);

		}
	}
}
