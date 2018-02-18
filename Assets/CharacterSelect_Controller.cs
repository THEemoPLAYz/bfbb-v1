using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class CharacterSelect_Controller : MonoBehaviour {

	public GameObject selection, playerControl, opponentControl, error, canvas;
	public GameObject beep, betterName, blawowa, deathPact, freeFood, iance, iceCube, losers;
	public Image playerPanel, opponentPanel;
	public Sprite unselected;
	public Button startButton;
	public TextMeshProUGUI playerName, opponentName;
	public bool selectingPlayer;
	public List<Sprite> characterThumbs;

	public void ErrorCheck(){

		if (playerPanel.sprite == unselected || opponentPanel.sprite == unselected
			|| playerControl.GetComponent<Dropdown> ().captionText.text == "Controller" || opponentControl.GetComponent<Dropdown> ().captionText.text == "Controller") {

			error.SetActive (true);

		} else {

			canvas.GetComponent<SceneSwither> ().ClickPlay ();

		}

	}


	//OPEN SELECTION AND DETECT WHICH PANEL TO CHANGE
	public void PlayerSelect () {
		selection.SetActive (true);
		selectingPlayer = true;
	}

	public void OpponentSelect () {
		selection.SetActive (true);
		selectingPlayer = false;
	}

	//SHOW CHARACTERS
	public void BeepShowChars(){

		beep.SetActive (true);
		betterName.SetActive (false);
		blawowa.SetActive (false);
		deathPact.SetActive (false);
		freeFood.SetActive (false);
		iance.SetActive (false);
		iceCube.SetActive (false);
		losers.SetActive (false);

	}

	public void BetterNameShowChars(){

		beep.SetActive (false);
		betterName.SetActive (true);
		blawowa.SetActive (false);
		deathPact.SetActive (false);
		freeFood.SetActive (false);
		iance.SetActive (false);
		iceCube.SetActive (false);
		losers.SetActive (false);

	}

	public void BlawowaShowChars(){

		beep.SetActive (false);
		betterName.SetActive (false);
		blawowa.SetActive (true);
		deathPact.SetActive (false);
		freeFood.SetActive (false);
		iance.SetActive (false);
		iceCube.SetActive (false);
		losers.SetActive (false);

	}

	public void DeathPactShowChars(){

		beep.SetActive (false);
		betterName.SetActive (false);
		blawowa.SetActive (false);
		deathPact.SetActive (true);
		freeFood.SetActive (false);
		iance.SetActive (false);
		iceCube.SetActive (false);
		losers.SetActive (false);

	}

	public void FreeFoodShowChars(){

		beep.SetActive (false);
		betterName.SetActive (false);
		blawowa.SetActive (false);
		deathPact.SetActive (false);
		freeFood.SetActive (true);
		iance.SetActive (false);
		iceCube.SetActive (false);
		losers.SetActive (false);

	}

	public void IanceShowChars(){

		beep.SetActive (false);
		betterName.SetActive (false);
		blawowa.SetActive (false);
		deathPact.SetActive (false);
		freeFood.SetActive (false);
		iance.SetActive (true);
		iceCube.SetActive (false);
		losers.SetActive (false);

	}

	public void IceCubeShowChars(){

		beep.SetActive (false);
		betterName.SetActive (false);
		blawowa.SetActive (false);
		deathPact.SetActive (false);
		freeFood.SetActive (false);
		iance.SetActive (false);
		iceCube.SetActive (true);
		losers.SetActive (false);

	}

	public void LosersShowChars(){

		beep.SetActive (false);
		betterName.SetActive (false);
		blawowa.SetActive (false);
		deathPact.SetActive (false);
		freeFood.SetActive (false);
		iance.SetActive (false);
		iceCube.SetActive (false);
		losers.SetActive (true);

	}
	//CHANGE PLAYER TITLES
	void ChangeTitleName(){

		if (selectingPlayer) {

			playerName.text = playerPanel.sprite.name;

		} else {

			opponentName.text = opponentPanel.sprite.name;

		}

	}

	//CHARACTER SELECTED AND CHANGE CHOSEN PANEL
	public void EightBallSelected(){

		if(selectingPlayer){

			for (int i = 0; i < characterThumbs.Count; i++) {
				if (characterThumbs [i].name == "8-Ball") {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);

	}
	public void BalloonySelected(){

			for (int i = 0; i < characterThumbs.Count; i++) {
				if (characterThumbs [i].name == "Balloony") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
				}
			}

		ChangeTitleName ();
			selection.SetActive (false);
	}
	public void BarfBagSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Barf Bag") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void BasketBallSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Basketball") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void BellSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Bell") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void BlackHoleSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Black Hole") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void BlockySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Blocky") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void BombySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Bomby") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void BookSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Book") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void BottleSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Bottle") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void BraceletySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Bracelety") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void BubbleSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Bubble") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void CakeSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Cake") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void ClockSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Clock") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void CloudySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Cloudy") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void CoinySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Coiny") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void DavidSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "David") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void DonutSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Donut") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void DoraSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Dora") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void EggySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Eggy") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void EraserSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Eraser") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void FannySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Fanny") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void FireySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Firey") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void FireyJrSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Firey Jr") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void FlowerSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Flower") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void FoldySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Foldy") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void FriesSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Fries") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void GatySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Gaty") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void GelatinSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Gelatin") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void GolfBallSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Golf Ball") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void GrassySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Grassy") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void IceCubeSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Ice Cube") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void LeafySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Leafy") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void LightningSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Lightning") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void LiySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Liy") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void LollipopSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Lollipop") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void LoserSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Loser") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void MarkerSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Marker") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void MatchSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Match") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void NailySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Naily") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void NeedleSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Needle") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void NickelSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Nickel") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void PenSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Pen") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void PencilSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Pencil") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void PieSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Pie") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void PillowSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Pillow") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void PinSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Pin") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void PuffBallSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Puffball") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void RemoteSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Remote") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void RobotFlowerSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Robot Flower") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void RobotySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Roboty") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void RockySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Rocky") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void RubySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Ruby") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void SawSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Saw") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void SnowBallSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Snowball") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void SpongeySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Spongy") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void StapySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Stapy") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void TacoSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Taco") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void TeardropSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Teardrop") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void TennisBallSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Tennis Ball") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void TreeSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Tree") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void TVSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "TV") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void WoodySelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Woody") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}
	public void YellowFaceSelected(){

		for (int i = 0; i < characterThumbs.Count; i++) {
			if (characterThumbs [i].name == "Yellow Face") {
				if (selectingPlayer) {
					playerPanel.sprite = characterThumbs [i];
					break;
				} else {
					opponentPanel.sprite = characterThumbs [i];
					break;
				}
			}
		}

		ChangeTitleName ();
		selection.SetActive (false);
	}

}
