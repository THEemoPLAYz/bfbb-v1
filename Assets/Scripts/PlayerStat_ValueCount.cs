using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStat_ValueCount : MonoBehaviour {

    public GameObject player;
    private int currentValue;
    public int setValue;
    public TextMeshProUGUI text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        while(currentValue != setValue)
        {

            currentValue += 1;
            text.text = currentValue.ToString();

            return;
        }

	}
}
