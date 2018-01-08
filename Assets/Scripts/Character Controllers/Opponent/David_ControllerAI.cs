using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class David_ControllerAI : MonoBehaviour {

	[Header("Variables")]
	public float speed;


	[Space]

	[Header("GameObjects")]
	public GameObject player;
	public GameObject punchtriggerR;
	public GameObject punchtriggerL;
	public GameObject sparks;

	[Space]

	[Header("Animation")]
	public Animator anim;
	public RuntimeAnimatorController davidcontroller;

	[Space]

	[Header("Sprites")]
	public SpriteRenderer currentsprite;
	public Sprite right1, right2, right3, right4;
	public Sprite left1, left2, left3, left4;

	// Use this for initialization
	void Start () {
		anim.runtimeAnimatorController = davidcontroller;
	}
	
	// Update is called once per frame
	void Update () {
		//AI
		float distance = Vector3.Distance (transform.position, player.transform.position);
		float direction = player.transform.position.x - transform.position.x;

		//Negative = Player is on the left
		//Positive = Player is on the right

		if (distance > 1.2f && direction < 0f) {

			punchtriggerR.SetActive (false);
			punchtriggerL.SetActive (false);
			transform.Translate (Vector3.left * speed * Time.deltaTime);
			anim.SetInteger ("Direction", -1);
			anim.SetBool ("IsMoving", true);


		} else if (distance > 1.2f && direction > 0f) {

			punchtriggerR.SetActive (false);
			punchtriggerL.SetActive (false);
			transform.Translate (Vector3.right * speed * Time.deltaTime);
			anim.SetInteger ("Direction", 1);
			anim.SetBool ("IsMoving", true);

		} else {

			anim.SetBool ("IsMoving", false);
			anim.SetTrigger ("Scream");
			sparks.SetActive(true);

		}

		if (currentsprite.sprite == right1 || currentsprite.sprite == right2 || currentsprite.sprite == right3 || currentsprite.sprite == right4) {

			punchtriggerR.SetActive (true);
			punchtriggerL.SetActive (false);

		}
		if (currentsprite.sprite == left1 || currentsprite.sprite == left2 || currentsprite.sprite == left3 || currentsprite.sprite == left4) {

			punchtriggerR.SetActive (false);
			punchtriggerL.SetActive (true);

		}


		if (transform.position.x > 21f) {

			transform.position = new Vector3 (21f, transform.position.y, transform.position.z);

		} else if (transform.position.x < -21f) {

			transform.position = new Vector3 (-21f, transform.position.y, transform.position.z);

		}
	}
}
