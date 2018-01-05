using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pencil_ControllerPlayer : MonoBehaviour {

	public Rigidbody rb;
	public GameObject punchtriggerR, punchTriggerL;

	[Header("Variables")]
	public float speed, jumppower;
	public bool jumped;

	[Space]

	[Header("Animation")]
	public Animator anim;
	public RuntimeAnimatorController pencilcontroller;

	[Space]

	[Header("Sprite")]
	public Sprite punchR;
	public Sprite punchL;
	public SpriteRenderer playersprite;

	[Space]

	[Header("Audio")]
	public AudioSource audio;
	public AudioClip hmph;

	// Use this for initialization
	void Start () {
		anim.runtimeAnimatorController = pencilcontroller;
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){

			rb.velocity =  new Vector3(0f, rb.velocity.y, rb.velocity.z);
			transform.Translate (Vector3.left * speed * Time.deltaTime);
			anim.SetInteger ("Direction", -1);
			anim.SetBool ("IsMoving", true);

		} else if (Input.GetKey(KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {

			rb.velocity =  new Vector3(0f, rb.velocity.y, rb.velocity.z);
			transform.Translate (Vector3.right * speed * Time.deltaTime);
			anim.SetInteger ("Direction", 1);
			anim.SetBool ("IsMoving", true);

		} else if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){

			if (jumped == false) {
				anim.SetBool ("Jumped", true);
			}
		} else if (Input.GetKeyDown (KeyCode.Z)) {

			anim.SetTrigger ("Punch");
			audio.PlayOneShot (hmph);

		}

		else {

			anim.SetBool ("IsMoving", false);

		}

		if (transform.position.y < 1.5f) {
			transform.position = new Vector3(transform.position.x, 1.52f, transform.position.z);
		}

		if (playersprite.sprite == punchR) {

			punchtriggerR.SetActive (true);
			punchTriggerL.SetActive (false);

		} else if (playersprite.sprite == punchL) {

			punchTriggerL.SetActive (true);
			punchtriggerR.SetActive (false);

		} else {

			punchtriggerR.SetActive (false);
			punchTriggerL.SetActive (false);

		}

		if (transform.position.x > 21f) {

			transform.position = new Vector3 (21f, transform.position.y, transform.position.z);

		} else if (transform.position.x < -21f) {

			transform.position = new Vector3 (-21f, transform.position.y, transform.position.z);

		}

	}

	void OnCollisionEnter (Collision c){

		jumped = false;
		anim.SetBool ("Jumped", false);

	}

	public void Jump(){

		if (jumped == false) {
			rb.AddForce (Vector3.up * jumppower, ForceMode.Impulse);
			jumped = true;
		}
	}
}
