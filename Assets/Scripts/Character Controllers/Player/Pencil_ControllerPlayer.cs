using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.UI;

public class Pencil_ControllerPlayer : MonoBehaviour {

	public Rigidbody rb;
	public GameObject punchtriggerR, punchTriggerL, specialTrigger,cam, specialParticles1, specialParticles2, playerCenter, opponent;

	[Header("Initialize Stuff")]
	public BoxCollider collider;
	public Vector3 ColliderPosition;
	public Vector3 ColliderScale;
	public Vector3 PunchTriggerRPosition;
	public Vector3 PunchTriggerLPosition;
	public Text playerName;


	[Space]

	[Header("Variables")]
	public float speed;
	public float jumppower;
	public bool jumped, freezeControl = false;

	[Space]

	[Header("Animation")]
	public Animator anim;
	public RuntimeAnimatorController pencilAnim;

	// Use this for initialization
	void Start () {
		collider.center = new Vector3 (ColliderPosition.x, ColliderPosition.y, ColliderPosition.z);
		collider.size = new Vector3 (ColliderScale.x, ColliderScale.y, ColliderScale.z);
		punchtriggerR.GetComponent<BoxCollider> ().center = new Vector3 (PunchTriggerRPosition.x, PunchTriggerRPosition.y, PunchTriggerRPosition.z);
		punchTriggerL.GetComponent<BoxCollider> ().center = new Vector3 (PunchTriggerLPosition.x, PunchTriggerLPosition.y, PunchTriggerLPosition.z);
		playerName.text = "PENCIL";
		anim.SetInteger ("Direction", 1);
		anim.runtimeAnimatorController = pencilAnim;
	}
	
	// Update is called once per frame
	void Update(){

		Vector3 pencilvelocity;
		pencilvelocity = rb.velocity;
		Debug.Log (pencilvelocity);


		if (freezeControl == false) {
			if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {

				rb.velocity = new Vector3 (0f, rb.velocity.y, rb.velocity.z);
				transform.Translate (Vector3.left * speed * Time.deltaTime);
				anim.SetInteger ("Direction", -1);
				anim.SetBool ("IsMoving", true);

			} else if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {

				rb.velocity = new Vector3 (0f, rb.velocity.y, rb.velocity.z);
				transform.Translate (Vector3.right * speed * Time.deltaTime);
				anim.SetInteger ("Direction", 1);
				anim.SetBool ("IsMoving", true);

			} else if (Input.GetKeyDown (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {

				if (jumped == false) {
					anim.SetBool ("Jumped", true);
				}
			} else if (Input.GetKeyDown (KeyCode.Z)) {

				anim.SetTrigger ("Punch");

			} else if (Input.GetKey (KeyCode.Z) && Input.GetKey (KeyCode.X) || Input.GetKey (KeyCode.X) && Input.GetKey (KeyCode.Z)) {

				if (gameObject.GetComponent<Player_Controller> ().powerbar.value == 1f) {

					anim.SetTrigger ("Special");
					freezeControl = true;

				}

			} else {

				anim.SetBool ("IsMoving", false);

			}
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
	public void PunchR(){


		punchtriggerR.SetActive (true);
		punchTriggerL.SetActive (false);


	}
	public void PunchL(){


		punchtriggerR.SetActive (false);
		punchTriggerL.SetActive (true);


	}
	public void StopPunch(){


		punchtriggerR.SetActive (false);
		punchTriggerL.SetActive (false);


	}


	//Special Handlers
	public void Special_CameraFocusToPlayer(){

		cam.GetComponent<Camera_Controller> ().enabled = false;
		cam.GetComponent<Special_PlayerFocus> ().enabled = true;
		opponent.GetComponent<David_ControllerAI> ().enabled = false;

	}
	public void Special_CameraBackToNormal(){

		cam.GetComponent<Camera_Controller> ().enabled = true;
		cam.GetComponent<Special_PlayerFocus> ().enabled = false;
		opponent.GetComponent<David_ControllerAI> ().enabled = true;

	}
	public void Special_Done(){

		freezeControl = false;
		specialTrigger.SetActive (false);

	}
	public void Special_Particles(){

		GameObject specialClone1 = Instantiate (specialParticles1, playerCenter.transform.position, Quaternion.identity);
		GameObject specialClone2 = Instantiate (specialParticles2, playerCenter.transform.position, Quaternion.identity);
		specialClone1.SetActive (true);
		specialClone2.SetActive (true);

	}
	public void Special_JumpR(){

		rb.velocity = new Vector3 (5f, 15f, 0f);

	}
	public void Special_JumpL(){

		rb.velocity = new Vector3 (-5f, 15f, 0f);

	}
	public void Special_Dive(){

		rb.velocity = new Vector3 (1f, -15f, 0f);
		specialTrigger.SetActive (true);

	}
}
