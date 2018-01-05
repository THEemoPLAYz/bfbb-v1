using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwither : MonoBehaviour {

	public GameObject transitionPlay, transitionOptions;

	public void ClickPlay(){

		transitionPlay.SetActive (true);

	}

	public void ClickOptions(){

		transitionOptions.SetActive (true);

	}

	public void LoadPlay(){
		
		SceneManager.LoadSceneAsync("Play");

	}
	public void LoadOptions(){

		SceneManager.LoadSceneAsync ("Options");

	}

	public void LoadExit(){

		Application.Quit();

	}
}
