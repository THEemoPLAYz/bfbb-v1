using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InfoHover_Character : MonoBehaviour, IPointerEnterHandler{

	public GameObject infoHover, referenceChar;
	public string hoveringChar;
	public List<Sprite> charThumbs;

	// Use this for initialization

	void Start(){

		charThumbs = referenceChar.GetComponent<CharacterSelect_Controller> ().characterThumbs;

	}

	public void OnPointerEnter(PointerEventData eventData){
		
		for (int i = 0; i < charThumbs.Count; i++) {

			if (eventData.pointerEnter.name == charThumbs [i].name) {
				
				infoHover.GetComponent<InfoHover_Main> ().charShow = charThumbs [i].name;
				break;

			}

		}

	}
}
