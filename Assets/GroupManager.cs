using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupManager : MonoBehaviour {

    [Header("Assign your teammates")]
    public GameObject one;
    public GameObject two, three, four, five, six, seven, eight;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void enableTeammates()
    {

        StartCoroutine (enableTeammatesOverTime());

    }

    IEnumerator enableTeammatesOverTime()
    {

        one.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        two.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        three.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        four.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        five.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        six.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        seven.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        eight.SetActive(true);


    }
    public void disableTeammates()
    {

        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);
        four.SetActive(false);
        five.SetActive(false);
        six.SetActive(false);
        seven.SetActive(false);
        eight.SetActive(false);

    }
}
