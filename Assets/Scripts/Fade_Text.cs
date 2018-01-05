using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade_Text : MonoBehaviour {

	public float fadeOutTime;
	public GameObject player, opponent;

	public void FadeOut()
	{
		StartCoroutine(FadeOutRoutine());
		player.GetComponent<Player_Controller> ().enabled = false;
		opponent.GetComponent<David_ControllerAI> ().enabled = false;
	}
	private IEnumerator FadeOutRoutine()
	{ 
		Text text = GetComponent<Text>();
		Color originalColor = text.color;
		for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
		{
			text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t/fadeOutTime));
			yield return null;
		}
		gameObject.SetActive (false);

		player.GetComponent<Player_Controller> ().enabled = true;
		opponent.GetComponent<David_ControllerAI> ().enabled = true;
	}
}
