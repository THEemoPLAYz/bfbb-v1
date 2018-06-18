using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat_GetNormalAttacks : MonoBehaviour {

    public GameObject player;
    private int punchValue, kickValue;
    private int getValue;

	// Use this for initialization
	void Start () {

        punchValue = player.GetComponent<Player_Controller>().playerstatPunch;
        kickValue = player.GetComponent<Player_Controller>().playerstatKick;

        getValue = punchValue + kickValue;

        GetComponent<PlayerStat_ValueCount>().setValue = getValue;

    }
}
