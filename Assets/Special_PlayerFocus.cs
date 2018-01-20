using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special_PlayerFocus : MonoBehaviour {

	Vector3 playerPosition;
	public GameObject playerCenter;
	public float lerpSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		playerPosition = new Vector3 (playerCenter.transform.position.x + 2f, playerCenter.transform.position.y, playerCenter.transform.position.z - 7f);
		transform.position = Vector3.Lerp (transform.position, playerPosition, Time.deltaTime * lerpSpeed);
		gameObject.GetComponent<Camera>().fieldOfView = 36f;

	}
}
