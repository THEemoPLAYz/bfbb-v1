using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Object : MonoBehaviour {

    public Transform targetObject;
    public Vector3 offset;
    public float time;

    private Vector3 currentVelocity;
	
	// Update is called once per frame
	void Update () {

        Vector3 target = new Vector3(targetObject.position.x + offset.x, targetObject.position.y + offset.y, targetObject.position.z + offset.z);
        transform.position = Vector3.SmoothDamp(transform.position, target, ref currentVelocity, time);

	}
}
