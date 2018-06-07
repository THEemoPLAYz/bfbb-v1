using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSelectCamera_Controller : MonoBehaviour {

	public Animator anim;

	public void EnterCameraPan(){

		gameObject.GetComponent<Camera_Pan> ().enabled = true;

	}
	public void ExitCameraPan(){

		gameObject.GetComponent<Camera_Pan> ().enabled = false;


	}
	public void MatrixExit(){

		anim.SetTrigger ("Exit");

	}
}
