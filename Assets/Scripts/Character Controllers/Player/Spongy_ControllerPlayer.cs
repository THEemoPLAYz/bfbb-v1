using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.UI;

public class Spongy_ControllerPlayer : MonoBehaviour {

	public Rigidbody rb;
	public GameObject punchtriggerR, punchTriggerL, specialTrigger, cam, specialParticles1, specialParticles2, spongySplash, playerCenter, opponent, spongyUI;

	[Header("Initialize Stuff")]
	public BoxCollider collider;
	public Vector3 ColliderPosition;
	public Vector3 ColliderScale;
	public Vector3 PunchTriggerRPosition;
	public Vector3 PunchTriggerLPosition;


	[Space]

	[Header("Variables")]
	public float speed;
	public float jumppower;
	public float punchpower;
	public bool freezeControl = false;

	[Space]

	[Header("Animation")]
	public Animator anim;
	public RuntimeAnimatorController spongyAnim;

	// Use this for initialization
	void Start () {
		anim.runtimeAnimatorController = spongyAnim;
		anim.SetInteger ("Direction", 1);
		collider.center = new Vector3 (ColliderPosition.x, ColliderPosition.y, ColliderPosition.z);
		collider.size = new Vector3 (ColliderScale.x, ColliderScale.y, ColliderScale.z);
		punchtriggerR.GetComponent<BoxCollider> ().center = new Vector3 (PunchTriggerRPosition.x, PunchTriggerRPosition.y, PunchTriggerRPosition.z);
		punchTriggerL.GetComponent<BoxCollider> ().center = new Vector3 (PunchTriggerLPosition.x, PunchTriggerLPosition.y, PunchTriggerLPosition.z);
		//spongyUI.SetActive (true);
	}
	
	// Update is called once per frame
	void Update(){


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

			} else if (Input.GetKeyDown (KeyCode.Z)) {

				anim.SetTrigger ("Punch");

			} else if(Input.GetKeyDown(KeyCode.X)){

				anim.SetTrigger ("Kick");

			} else if ((Input.GetKey (KeyCode.Z) && Input.GetKey (KeyCode.X)) ||
				(Input.GetKey (KeyCode.X) && Input.GetKey (KeyCode.Z))) {

				if (gameObject.GetComponent<Player_Controller> ().powerbar.value == 1f) {

					anim.SetTrigger ("Special");
					freezeControl = true;

				}

			} else if ((Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.Z)) ||
				(Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.Z))) {

				if (gameObject.GetComponent<Player_Controller> ().powerbar.value > 0.1f) {

					anim.SetTrigger ("MiniSpecial");
					freezeControl = true;
					gameObject.GetComponent<Player_Controller> ().currentPower -= 0.1f;


				}

            }else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){

                anim.SetTrigger("Jump");

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
	public void SpongySplash(){

		GameObject spongySplashClone = Instantiate (spongySplash, spongySplash.transform.position, spongySplash.transform.rotation);
		spongySplashClone.transform.parent = gameObject.transform;
		spongySplashClone.SetActive (true);

	}
    public void ExitSpecial(){

        if(anim.GetInteger("Direction") > 0){



        }

    }
}
