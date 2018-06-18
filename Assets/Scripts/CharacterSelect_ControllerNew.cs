using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.PostProcessing;
using TMPro;

public class CharacterSelect_ControllerNew : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{

	public GameObject player1, player2, selection1, selection2, postProcess;
	public GameObject transitionCam, mainCam, selection1Cam, selection2Cam;
	public GameObject transitionCut;
	public GameObject hoveredObject, hologramController;
	public PostProcessingProfile chromaticTransition;
	public Image image1, image2;
	public TextMeshProUGUI name1, name2;
	public TextMeshPro infoTitle1, infoTitle2;
	public List<Sprite> charThumbs;
	public List<GameObject> charObjects;
	public bool selectingPlayer1;
    public string selectedChar1, selectedChar2;
    public int selectedController1, selectedController2;
    public AudioSource sound;
    public AudioClip error, hover, click;

	void Start(){

		transitionCam.SetActive (false);
		mainCam.SetActive (true);

	}
	public void StartBattle(){

        if (selectedChar1 == "")
        {
            sound.PlayOneShot(error);
            CharSelect_ShowSelection1();

        }
        else if (selectedChar2 == "")
        {

            sound.PlayOneShot(error);
            CharSelect_ShowSelection2();


        }
        else if (selectedController1 < 1)
        {

            sound.PlayOneShot(error);
            CharSelect_ShowSelection1();

        }
        else if (selectedController2 < 1)
        {

            sound.PlayOneShot(error);
            CharSelect_ShowSelection2();

        }
        else
        {

            mainCam.SetActive(false);
            transitionCam.SetActive(true);
            postProcess.GetComponent<PostProcessingBehaviour>().profile = chromaticTransition;
            StartCoroutine(LoadPlay());

        }

	}

	IEnumerator LoadPlay(){

		yield return new WaitForSeconds (2);

		transitionCut.SetActive (true);

        yield return new WaitForSeconds(2);

		SceneManager.LoadSceneAsync ("Play_Goiky");

	}

	public void CharSelect_ShowSelection1(){

		mainCam.SetActive (false);
		selection1Cam.SetActive (true);
		selection2Cam.SetActive (false);
		selectingPlayer1 = true;

	}
	public void CharSelect_ShowSelection2(){

		mainCam.SetActive (false);
		selection1Cam.SetActive (false);
		selection2Cam.SetActive (true);
		selectingPlayer1 = false;

	}
	public void CharSelect_ShowMain(){

		mainCam.SetActive (true);
		selection1Cam.SetActive (false);
		selection2Cam.SetActive (false);

	}
    public void Update_Controller1(int selectionIndex){

        selectedController1 = selectionIndex;

    }
    public void Update_Controller2(int selectionIndex)
    {

        selectedController2 = selectionIndex;

    }

	void Update(){

		if (Input.GetKeyDown (KeyCode.Escape)) {

			CharSelect_ShowMain ();

		}

	}

	public void CharSelect_SelectCharacter(GameObject selected){

        sound.PlayOneShot(click);

		if (selectingPlayer1 == true) {
			
			selectedChar1 = selected.name;
			image1.sprite = selected.GetComponent<Image> ().sprite;
			name1.text = selected.name;

		} else {

			selectedChar2 = selected.name;
			image2.sprite = selected.GetComponent<Image> ().sprite;
			name2.text = selected.name;

		}
	}

	public void OnPointerEnter(PointerEventData eventData){

		hoveredObject = eventData.pointerEnter;
		Debug.Log (hoveredObject.name);

		for (int i = 0; i < charObjects.Count; i++) {

			if (hoveredObject.name == charObjects [i].name) {

                sound.PlayOneShot(hover);
				infoTitle1.text = hoveredObject.name;
				infoTitle2.text = hoveredObject.name;

				if (charObjects [i].name == "Woody") {

					hologramController.GetComponent<CharSelect_HologramController> ().CharSelect_WoodyInfo ();
					break;

				} else if (charObjects [i].name == "David") {

					hologramController.GetComponent<CharSelect_HologramController> ().CharSelect_DavidInfo ();
					break;

				} else if (charObjects [i].name == "Pencil") {

					hologramController.GetComponent<CharSelect_HologramController> ().CharSelect_PencilInfo ();
					break;

				} else if (charObjects [i].name == "Spongy") {

					hologramController.GetComponent<CharSelect_HologramController> ().CharSelect_SpongyInfo ();
					break;

				}
            }

        }

	}
	public void OnPointerExit(PointerEventData eventData){

		infoTitle1.text = "Info";
		infoTitle2.text = "Info";
		hologramController.GetComponent<CharSelect_HologramController> ().CharSelect_DefaultInfo ();
		Debug.Log ("Exited");

	}
}
