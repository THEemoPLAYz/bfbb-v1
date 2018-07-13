using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special_PlayerFocus : MonoBehaviour {

	Vector3 playerPosition;
	public GameObject playerCenter, player, cam;
	public float lerpSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		player.GetComponent<Player_Controller> ().currentPower = 0f;
		playerPosition = new Vector3 (playerCenter.transform.position.x, playerCenter.transform.position.y, playerCenter.transform.position.z - 7f);
		transform.position = Vector3.Lerp (transform.position, playerPosition, Time.deltaTime * lerpSpeed);
		cam.GetComponent<Camera>().fieldOfView = 36f;

	}
}
