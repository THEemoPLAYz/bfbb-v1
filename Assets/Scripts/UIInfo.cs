using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInfo : MonoBehaviour {

	public GameObject infotoshow;

	public void EnablePlayInfo(){

		infotoshow.SetActive (true);

	}

	public void DisablePlayInfo(){

		infotoshow.SetActive (false);

	}
}
