using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwither : MonoBehaviour {

	public GameObject transition;

	public void LoadScene(string sceneName){

		transition.SetActive (true);
		SceneManager.LoadSceneAsync(sceneName);

	}

	public void Exit(){

		Application.Quit();

	}
}
