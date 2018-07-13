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
	}
	
	// Update is called once per frame
	void Update(){

        float moveHorizontal = Input.GetAxis("Horizontal");

		if (freezeControl == false) {
            if (moveHorizontal > 0) {

                anim.SetInteger("Direction", 1);
                anim.SetBool("IsMoving", true);
				rb.velocity = new Vector3 (0f, rb.velocity.y, rb.velocity.z);
                transform.Translate (Vector3.right * moveHorizontal * speed * Time.deltaTime);

            } else if (moveHorizontal < 0) {

                anim.SetInteger("Direction", -1);
                anim.SetBool("IsMoving", true);
				rb.velocity = new Vector3 (0f, rb.velocity.y, rb.velocity.z);
                transform.Translate (Vector3.left * -moveHorizontal * speed * Time.deltaTime);

			}
            else {

				anim.SetBool ("IsMoving", false);

            }


            if (Input.GetButtonDown("Punch"))
            {


                if (Input.GetButton("Punch") && Input.GetButton("Kick"))
                {

                    if (gameObject.GetComponent<Player_Controller>().powerbar.value == 1f)
                    {

                        anim.SetTrigger("Special");
                        freezeControl = true;
                        GetComponent<Player_Controller>().PlayerStat_Special();

                    }

                }
                else if (Input.GetButton("Duck") && Input.GetButton("Punch"))
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

            }
            if(Input.GetButtonDown("Kick")){

                anim.SetTrigger ("Kick");
                GetComponent<Player_Controller>().PlayerStat_Kick();

                return;

            } 
            if (Input.GetButtonDown("Jump")) {

                if (jumped == false) {
                    anim.SetBool ("Jumped", true);
                }

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

	public void PenJump(){

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
    public void Special_PenCapThrow()
    {
        opponent.GetComponent<Rigidbody>().AddForce(Vector3.right * 10f, ForceMode.Impulse);
        pencap.transform.position = new Vector3(playerCenter.transform.position.x + pencapOffsetX, playerCenter.transform.position.y, playerCenter.transform.position.z);
        pencap.GetComponent<PenCap_ControllerR>().enabled = true;
        pencap.GetComponent<PenCap_ControllerL>().enabled = false;
        pencap.SetActive(true);

     }
    public void Special_PenCapThrowL()
    {
        opponent.GetComponent<Rigidbody>().AddForce(Vector3.left * 10, ForceMode.Impulse);
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
