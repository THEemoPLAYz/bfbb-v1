using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour {

	private AudioSource _audioSource;
	void Awake()
	{
		_audioSource = GetComponent<AudioSource>();
		if (!_audioSource.isPlaying) {
			DontDestroyOnLoad (transform.gameObject);
		}
	}

	public void PlayMusic()
	{
		if (_audioSource.isPlaying) return;
		_audioSource.Play();
	}

	public void StopMusic()
	{
		_audioSource.Stop();
	}
}
