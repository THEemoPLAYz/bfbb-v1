using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoopyAmbience : MonoBehaviour {

    public AudioSource audioSource;

    [Header("Insert SPOOPY sounds!")]
    public List<AudioClip> sounds;

    [Space]

    public float minTime;
    public float maxTime;
    private float counter, setTime;

	// Use this for initialization
	void Start () {

        resetTimer();

	}
	
	// Update is called once per frame
	void Update () {

        counter += Time.deltaTime;
        if (counter > setTime){

            playSpoopySound();
            resetTimer();

        }
		
	}

    void playSpoopySound(){

        int randomSpoop = Random.Range(0, sounds.Count);
        AudioClip selectedSpoop = sounds[randomSpoop];
        audioSource.PlayOneShot(selectedSpoop);

    }

    void resetTimer(){

        counter = 0f;
        setTime = Random.Range(minTime, maxTime);

    }
}
