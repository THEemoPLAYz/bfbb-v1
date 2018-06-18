using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilLeafy_Controller : MonoBehaviour {

    public AudioSource sound;
    public AudioClip teleport;
    public float timer, teleportTime;
    public float minValue, maxValue;

	// Use this for initialization
	void Start () {
        teleportTime = Random.Range(minValue, maxValue);
	}
	
	// Update is called once per frame
	void Update () {
        timer = timer + Time.deltaTime;
        if (timer > teleportTime){

            transform.position = new Vector3(Random.Range(-20f, 20f), transform.position.y, Random.Range(-3, 27));
            sound.PlayOneShot(teleport);
            timer = 0f;
            teleportTime = Random.Range(minValue, maxValue);

        }
	}
}
