using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat_GetSpecial : MonoBehaviour {

    public GameObject player;
    private int specialValue;

    // Use this for initialization
    void Start ()
    {

        specialValue = player.GetComponent<Player_Controller>().playerstatSpecial;

        GetComponent<PlayerStat_ValueCount>().setValue = specialValue;

    }
}
