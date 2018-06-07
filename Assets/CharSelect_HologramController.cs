using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharSelect_HologramController : MonoBehaviour {

	public TextMeshPro description1, description2;

	[Space]
	public Animator hologram1, hologram2;


	[Space]

	[Header("Descriptions")]
	public string defaultDesc;
	public string woodyDesc, davidDesc, pencilDesc, spongyDesc;


	public void CharSelect_DefaultInfo(){

		hologram1.SetTrigger ("No Hologram");
		description1.text = defaultDesc;
		hologram2.SetTrigger ("No Hologram");
		description2.text = defaultDesc;

	}
	public void CharSelect_WoodyInfo(){

		hologram1.SetTrigger ("Woody");
		description1.text = woodyDesc;
		hologram2.SetTrigger ("Woody");
		description2.text = woodyDesc;

	}
	public void CharSelect_DavidInfo(){

		hologram1.SetTrigger ("David");
		description1.text = davidDesc;
		hologram2.SetTrigger ("David");
		description2.text = davidDesc;

	}
	public void CharSelect_PencilInfo(){

		hologram1.SetTrigger ("Pencil");
		description1.text = pencilDesc;
		hologram2.SetTrigger ("Pencil");
		description2.text = pencilDesc;

	}
	public void CharSelect_SpongyInfo(){

		hologram1.SetTrigger ("Spongy");
		description1.text = spongyDesc;
		hologram2.SetTrigger ("Spongy");
		description2.text = spongyDesc;

	}
}
