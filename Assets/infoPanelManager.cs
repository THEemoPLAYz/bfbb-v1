using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class infoPanelManager : MonoBehaviour {

    public string showingInfo;

    [Header("UI Components")]
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public Animator image;

    [Header("Character Descriptions")]
    public string leafy;
    public string spongy, pencil, david, pen, woody;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        title.text = showingInfo;
        image.SetTrigger(showingInfo);

       if(showingInfo == "Leafy")
        {

            description.text = leafy;

        }
        if (showingInfo == "David")
        {

            description.text = david;

        }
        if (showingInfo == "Spongy")
        {

            description.text = spongy;

        }
        if (showingInfo == "Pen")
        {

            description.text = pen;

        }
        if (showingInfo == "Pencil")
        {

            description.text = pencil;

        }
        if (showingInfo == "Woody")
        {

            description.text = woody;

        }

    }
}
