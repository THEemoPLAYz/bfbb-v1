using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float timer;
	public Text timerText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (timer > 0f)
        {
            timer = timer - Time.deltaTime;
            timerText.text = Mathf.Round(timer).ToString();
        }
	}
}
