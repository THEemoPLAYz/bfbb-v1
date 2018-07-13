using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour {

    public bool gamePaused;
    public GameObject pausePanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Escape)){

            if(gamePaused)
            {

                Resume();

            }
            else
            {

                Pause();

            }

        }

	}

    void Resume(){

        Time.timeScale = 1f;
        gamePaused = false;
        pausePanel.SetActive(false);

    }
    void Pause()
    {

        Time.timeScale = 0f;
        gamePaused = true;
        pausePanel.SetActive(true);

    }
}
