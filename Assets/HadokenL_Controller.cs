using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HadokenL_Controller : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.left * speed * Time.deltaTime);

	}

}
