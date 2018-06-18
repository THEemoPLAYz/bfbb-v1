using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCard_Controller : MonoBehaviour {

    public GameObject winDecor, loseDecor;
    public GameObject normalStat, minispecialStat, specialStat;
    public GameObject homeButton;

    public void EndCardWin_ShowDecor() {

        winDecor.SetActive(true);

    }
    public void EndCardLose_ShowDecor()
    {

        loseDecor.SetActive(true);

    }
    public void EndCard_ShowStat()
    {

        StartCoroutine (Stats());

    }

    IEnumerator Stats()
    {
        normalStat.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        minispecialStat.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        specialStat.SetActive(true);
        yield return new WaitForSeconds(2f);
        homeButton.SetActive(true);

    }
}
