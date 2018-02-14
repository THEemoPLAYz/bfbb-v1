using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Pan : MonoBehaviour {


	float XCam, YCam;
	float XCenter, YCenter;
	float XMouse, YMouse;
	float XDistance, YDistance;
	public float Offset, smoothTime;
	private Vector3 velocity;

	// Use this for initialization
	void Start () {
		
		XCenter = transform.position.x;
		YCenter = transform.position.y;

	}

	// Update is called once per frame
	void Update () {
		
		XMouse = Input.mousePosition.x;
		YMouse = Input.mousePosition.y;

		XDistance = XCenter - XMouse;
		YDistance = YCenter - YMouse;

		Vector3 newposition = new Vector3(XCenter - (XDistance/Offset), YCenter - (YDistance/Offset), transform.position.z);

		transform.position = Vector3.SmoothDamp (transform.position, newposition, ref velocity, smoothTime);

	}
}
