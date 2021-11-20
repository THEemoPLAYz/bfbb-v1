using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwither : MonoBehaviour {

	public GameObject transitionPlay, transitionOptions, transitionMain, loader;

	public void ClickPlay(){

		transitionPlay.SetActive (true);

	}

	public void ClickOptions(){

		transitionOptions.SetActive (true);

	}

	public void ClickMainMenu(){

		transitionMain.SetActive (true);

	}

	public void LoadPlay(){
		
		SceneManager.LoadSceneAsync("Play");
		loader.SetActive (true);

	}
	public void LoadOptions(){

		SceneManager.LoadSceneAsync ("Options");
		loader.SetActive (true);

	}
	public void LoadMain(){

		SceneManager.LoadSceneAsync ("MainMenu");
		loader.SetActive (true);

	}
	public void LoadCharacterSelect(){

		SceneManager.LoadSceneAsync ("CharacterSelect3");
		loader.SetActive (true);

	}

	public void LoadExit(){

		Application.Quit();

	}
}
