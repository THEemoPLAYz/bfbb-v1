using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.UI;

public class Pen_ControllerPlayer : MonoBehaviour {

	public Rigidbody rb;
	public GameObject punchtriggerR, punchtriggerL, specialtriggerR, specialtriggerL, cam, specialParticles1, specialParticles2, playerCenter, opponent, pencap, getpencapEffect;

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
	public float punchpower;
    public float pencapOffsetX;
	public bool jumped, freezeControl = false;

	[Space]

	[Header("Animation")]
	public Animator anim;
	public RuntimeAnimatorController penAnim, penUncapAnim;

	// Use this for initialization
	void Start () {

        GetComponent<Player_Controller>().currentDebris = GetComponent<Player_Controller>().penDebris;
		anim.runtimeAnimatorController = penAnim;
		anim.SetInteger ("Direction", 1);
		collider.center = new Vector3 (ColliderPosition.x, ColliderPosition.y, ColliderPosition.z);
		collider.size = new Vector3 (ColliderScale.x, ColliderScale.y, ColliderScale.z);
		punchtriggerR.GetComponent<BoxCollider> ().center = new Vector3 (PunchTriggerRPosition.x, PunchTriggerRPosition.y, PunchTriggerRPosition.z);
		punchtriggerL.GetComponent<BoxCollider> ().center = new Vector3 (PunchTriggerLPosition.x, PunchTriggerLPosition.y, PunchTriggerLPosition.z);
		playerName.text = "PENCIL";
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

			} else if (Input.GetKeyDown (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {

				if (jumped == false) {
					anim.SetBool ("Jumped", true);
				}

			} else if (Input.GetKeyDown (KeyCode.Z))
            {
                if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.X) || Input.GetKey(KeyCode.X) && Input.GetKey(KeyCode.Z))
                {

                    if (gameObject.GetComponent<Player_Controller>().powerbar.value == 1f)
                    {

                        anim.SetTrigger("Special");
                        freezeControl = true;
                        GetComponent<Player_Controller>().PlayerStat_Special();

                    }

                }
                 else if ((Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.Z)) ||
              (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.Z)))
                {

                    if (gameObject.GetComponent<Player_Controller>().powerbar.value > 0.1f)
                    {

                        anim.SetTrigger("MiniSpecial");
                        freezeControl = true;
                        gameObject.GetComponent<Player_Controller>().currentPower -= 0.1f;
                        GetComponent<Player_Controller>().PlayerStat_MiniSpecial();

                    }

                }
                else
                {
                    anim.SetTrigger("Punch");
                    GetComponent<Player_Controller>().PlayerStat_Punch();
                }

            } else if(Input.GetKeyDown(KeyCode.X)){

			    anim.SetTrigger ("Kick");
                GetComponent<Player_Controller>().PlayerStat_Kick();

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

        if(c.gameObject.tag == "PenCap")
        {

            c.gameObject.SetActive(false);
            Pen_NormalState();

        }

	}

	public void Jump(){

		if (jumped == false) {
			rb.AddForce (Vector3.up * jumppower, ForceMode.Impulse);
			jumped = true;
		}
	}
	public void PunchR(){


		punchtriggerR.SetActive (true);
		punchtriggerL.SetActive (false);


	}
	public void PunchL(){


		punchtriggerR.SetActive (false);
		punchtriggerL.SetActive (true);


	}
    public void Pen_MiniSpecialR()
    {

        specialtriggerR.SetActive(true);
        specialtriggerL.SetActive(false);

    }
    public void Pen_MiniSpecialL()
    {

        specialtriggerR.SetActive(false);
        specialtriggerL.SetActive(true);

    }
    public void StopPunch(){

		punchtriggerR.SetActive (false);
		punchtriggerL.SetActive (false);
        specialtriggerR.SetActive(false);
        specialtriggerL.SetActive(false);

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

	}
	public void Special_Particles(){

		GameObject specialClone1 = Instantiate (specialParticles1, playerCenter.transform.position, Quaternion.identity);
		GameObject specialClone2 = Instantiate (specialParticles2, playerCenter.transform.position, Quaternion.identity);
		specialClone1.SetActive (true);
		specialClone2.SetActive (true);

	}
    public void Special_PenCapThrowR()
    {

        pencap.transform.position = new Vector3(playerCenter.transform.position.x + pencapOffsetX, playerCenter.transform.position.y, playerCenter.transform.position.z);
        pencap.GetComponent<PenCap_ControllerR>().enabled = true;
        pencap.GetComponent<PenCap_ControllerL>().enabled = false;
        pencap.SetActive(true);

    }
    public void Special_PenCapThrowL()
    {

        pencap.transform.position = new Vector3(playerCenter.transform.position.x - pencapOffsetX, playerCenter.transform.position.y, playerCenter.transform.position.z);
        pencap.GetComponent<PenCap_ControllerR>().enabled = false;
        pencap.GetComponent<PenCap_ControllerL>().enabled = true;
        pencap.SetActive(true);

    }
    public void Pen_UncapState()
    {

        anim.runtimeAnimatorController = penUncapAnim;

    }
    public void Pen_NormalState() {

        anim.runtimeAnimatorController = penAnim;
        GameObject pencapEffect = Instantiate(getpencapEffect, playerCenter.transform.position, Quaternion.identity);
        pencapEffect.SetActive(true);

    }
}
