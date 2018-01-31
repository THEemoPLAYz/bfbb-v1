using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_AnimationController : MonoBehaviour {

	public Animator anim;
	public RuntimeAnimatorController pencil, woody;

	// Use this for initialization
	void Start () {

		if (gameObject.GetComponent<Pencil_ControllerPlayer> ().enabled == true) {

			anim.runtimeAnimatorController = pencil;

		} else if (gameObject.GetComponent<Woody_ControllerPlayer> ().enabled == true) {

			anim.runtimeAnimatorController = woody;

		}

	}
}
