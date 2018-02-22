using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeVisualizer : MonoBehaviour {

	public Slider volume;
	public TextMeshProUGUI textValue;
	public RectTransform rt;

	// Use this for initialization
	void Start () {

		rt = gameObject.GetComponent<RectTransform> (); 

	}
	
	// Update is called once per frame
	void Update () {


		float volumeHeight = volume.value;
		rt.sizeDelta = new Vector2(rt.rect.width ,volumeHeight);
		textValue.text = (volume.value / volume.maxValue * 100).ToString() + "%";

	}
}
