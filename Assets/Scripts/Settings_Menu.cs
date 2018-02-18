using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class Settings_Menu : MonoBehaviour {

	public AudioMixer audioMixer;
	public Dropdown resolutionDropdown, qualityDropdown;
	public GameObject camAudio;
	public Button audioButton;
	public Slider audioSlider;
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
	}

	public void SetResolution (int resolutionIndex){

		Resolution resolution = resolutions [resolutionIndex];
		Screen.SetResolution (resolution.width, resolution.height, Screen.fullScreen);

	}

	public void SetVolume(float volume){

		audioMixer.SetFloat ("volume", (volume - 100f));

	}

	public void SetQuality(int qualityIndex){

		QualitySettings.SetQualityLevel (qualityIndex);

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
}
