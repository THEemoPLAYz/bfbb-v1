using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UISounds_Controller : MonoBehaviour, IPointerEnterHandler {

	public AudioSource audio;
	public AudioClip hover, click, error;

	// Use this for initialization
	public void OnPointerEnter(PointerEventData eventData){

		if (eventData.pointerEnter.GetComponent<Button> ()) {

			audio.PlayOneShot (hover, 0.75f);

		}

	}
	public void PlayButtonClick(){

		audio.PlayOneShot (click, 0.75f);

	}
	public void PlayError(){

		audio.PlayOneShot (error, 0.75f);

	}
}
