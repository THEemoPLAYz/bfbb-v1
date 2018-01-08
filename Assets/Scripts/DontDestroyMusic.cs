using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour {

	public List<AudioClip> music;

	private AudioSource _audioSource;
	void Awake()
	{
		_audioSource = GetComponent<AudioSource>();
		int randomize = Random.Range (0, music.Count);
		_audioSource.clip = music[randomize];
		DontDestroyOnLoad(transform.gameObject);
	}

	public void PlayMusic()
	{
		if (_audioSource.isPlaying) return;
		_audioSource.Play();
	}

	public void StopMusic()
	{
		Destroy (gameObject);
		_audioSource.Stop();
	}
}
