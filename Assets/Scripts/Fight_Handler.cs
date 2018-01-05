using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fight_Handler : MonoBehaviour {

	float round;
	public Text roundnumber;


	// Use this for initialization
	void Start () {
		round = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		roundnumber.text = "ROUND " + round;
	}
}
