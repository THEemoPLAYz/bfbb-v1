using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat_GetMiniSpecial : MonoBehaviour {

    public GameObject player;
    private int minispecialValue;


	void Start () {

        minispecialValue = player.GetComponent<Player_Controller>().playerstatMiniSpecial;

        GetComponent<PlayerStat_ValueCount>().setValue = minispecialValue;

	}
}
