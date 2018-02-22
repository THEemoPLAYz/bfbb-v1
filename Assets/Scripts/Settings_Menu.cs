using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class Settings_Menu : MonoBehaviour {

	public AudioMixer audioMixer;
	public Dropdown resolutionDropdown, qualityDropdown;
	public GameObject camAudio, camResolution, camQuality;
	public Dropdown dropdownResolution, dropdownQuality;
	public Slider audioSlider;
	public TextMeshProUGUI textResolution;
	public Animator visualResolution;
	public string ratio;
	Resolution[] resolutions;

	void Start() {

		resolutions = Screen.resolutions;

		resolutionDropdown.ClearOptions ();

		List<string> options = new List<string> ();

		int currentResolutionIndex = 0;
		for (int i = 0; i < resolutions.Length; i++) {

			string option = resolutions[i].width + " x " + resolutions[i].height;
			options.Add (option);

			if (resolutions [i].width == Screen.currentResolution.width &&
				resolutions [i].height == Screen.currentResolution.height) {

				currentResolutionIndex = i;
			}
		}

		resolutionDropdown.AddOptions (options);
		resolutionDropdown.value = currentResolutionIndex;
		resolutionDropdown.RefreshShownValue ();

		FindResolutionVisual ();
		SetResolutionVisual ();
	}

	void Update(){
	}

	public void SetResolution (int resolutionIndex){

		Resolution resolution = resolutions [resolutionIndex];
		Screen.SetResolution (resolution.width, resolution.height, Screen.fullScreen);

		FindResolutionVisual ();
		SetResolutionVisual ();

	}

	public void SetVolume(float volume){

		audioMixer.SetFloat ("volume", (volume - 100f));

	}

	public void SetQuality(int qualityIndex){

		QualitySettings.SetQualityLevel (qualityIndex);

	}
	public void SetResolutionVisual(){
		
		if (ratio == "16:9") {

			textResolution.text = "16:9";
			visualResolution.SetTrigger ("16.9");

		} else if (ratio == "3:2") {

			textResolution.text = "3:2";
			visualResolution.SetTrigger ("3.2");

		} else {

			textResolution.text = "4:3";
			visualResolution.SetTrigger ("4.3");

		}

	}
	public void FindResolutionVisual(){

		if (Camera.main.aspect >= 1.7) {

			ratio = "16:9";

		} else if (Camera.main.aspect >= 1.5) {

			ratio = "3:2";

		} else {

			ratio = "4:3";

		}
	}

	public void FocusAudio(){

		if (camAudio.activeSelf == false) {
			camAudio.SetActive (true);
			audioSlider.interactable = true;
		} else {
			camAudio.SetActive (false);
			audioSlider.interactable = false;
		}

	}
	public void FocusResolution(){

		if (camResolution.activeSelf == false) {

			camResolution.SetActive (true);
			dropdownResolution.interactable = true;

		} else {

			camResolution.SetActive (false);
			dropdownResolution.interactable = false;

		}

	}

	public void FocusQuality(){

		if (camQuality.activeSelf == false) {

			camQuality.SetActive (true);
			dropdownQuality.interactable = true;
		
		} else {

			camQuality.SetActive (false);
			dropdownQuality.interactable = false;

		}

	}
}
