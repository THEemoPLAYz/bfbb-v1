using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_FollowCamera : MonoBehaviour {

	public GameObject cam;
	public Vector3 offset;
	public float speedDamp;

	private Vector3 velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 currentPosition = transform.position;
		Vector3 newPosition = cam.transform.position + offset;
		transform.position = Vector3.SmoothDamp (currentPosition, newPosition, ref velocity, speedDamp);

	}
}
