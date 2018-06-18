using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teamPanelManager : MonoBehaviour {

    [Header("Teams")]
    public GameObject beep;
    public GameObject betterName, blawowa, deathPact, freeFood, iance, iceCube, losers;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void enableTeamsInOrder()
    {

        StartCoroutine(enableTeamsOverTime());

    }

    IEnumerator enableTeamsOverTime()
    {
        
        beep.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        betterName.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        blawowa.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        deathPact.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        freeFood.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        iance.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        iceCube.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        losers.SetActive(true);

    }
}
