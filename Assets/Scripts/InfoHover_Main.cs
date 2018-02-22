using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoHover_Main : MonoBehaviour {

	public string charShow;
	public float smoothTime, offsetX, offsetY;
	public TextMeshProUGUI title, info;

	public string eightBallInfo, balloonyInfo, barfBagInfo, basketballInfo, bellInfo, blackHoleInfo, blockyInfo, bombyInfo, bookInfo, bottleInfo, braceletyInfo, bubbleInfo;
	public string cakeInfo, clockInfo, cloudyInfo, coinyInfo, davidInfo, donutInfo, doraInfo, eggyInfo, eraserInfo, fannyInfo, fireyInfo, fireyJrInfo, flowerInfo, foldyInfo;
	public string friesInfo, gatyInfo, gelatinInfo, golfBallInfo, grassyInfo, iceCubeInfo, leafyInfo, lightningInfo, liyInfo, lollipopInfo, loserInfo, markerInfo, matchInfo;
	public string nailyInfo, needleInfo, nickelInfo, penInfo, pencilInfo, pieInfo, pillowInfo, pinInfo, puffballInfo, remoteInfo, robotFlowerInfo, robotyInfo, rockyInfo;
	public string rubyInfo, sawInfo, snowballInfo, spongyInfo, stapyInfo, tacoInfo, teardropInfo, tennisBallInfo, treeInfo, tvInfo, woodyInfo, yellowFaceInfo;

	private Vector3 velocity;

	void Update () {
		
		Vector3 newposition = new Vector3 (Input.mousePosition.x - offsetX, Input.mousePosition.y - offsetY, transform.position.z);

		transform.position = Vector3.SmoothDamp (transform.position, newposition, ref velocity, smoothTime);

		if (charShow == "8-Ball") {

			EightBallText ();

		}
		if (charShow == "Balloony") {

			BalloonyText ();

		}
		if (charShow == "Barf Bag") {

			BarfBagText ();

		}
		if (charShow == "Basketball") {

			BasketballText ();

		}
		if (charShow == "Bell") {

			BellText ();

		}
		if (charShow == "Black Hole") {

			BlackHoleText ();

		}
		if (charShow == "Blocky") {

			BlockyText ();

		}
		if (charShow == "Bomby") {

			BombyText ();

		}
		if (charShow == "Book") {

			BookText ();

		}
		if (charShow == "Bottle") {

			BottleText ();

		}
		if (charShow == "Bracelety") {

			BraceletyText ();

		}
		if (charShow == "Bubble") {

			BubbleText ();

		}
		if (charShow == "Cake") {

			CakeText ();

		}
		if (charShow == "Clock") {

			ClockText ();

		}
		if (charShow == "Cloudy") {

			CloudyText ();

		}
		if (charShow == "Coiny") {

			CoinyText ();

		}
		if (charShow == "David") {

			DavidText ();

		}
		if (charShow == "Donut") {

			DonutText ();

		}
		if (charShow == "Dora") {

			DoraText ();

		}
		if (charShow == "Eggy") {

			EggyText ();

		}
		if (charShow == "Eraser") {

			EraserText ();

		}
		if (charShow == "Fanny") {

			FannyText ();

		}
		if (charShow == "Firey") {

			FireyText ();

		}
		if (charShow == "Firey Jr") {

			FireyJrText ();

		}
		if (charShow == "Flower") {

			FlowerText ();

		}
		if (charShow == "Foldy") {

			FoldyText ();

		}
		if (charShow == "Fries") {

			FriesText ();

		}
		if (charShow == "Gaty") {

			GatyText ();

		}
		if (charShow == "Gelatin") {

			GelatinText ();

		}
		if (charShow == "Golf Ball") {

			GolfBallText ();

		}
		if (charShow == "Grassy") {

			GrassyText ();

		}
		if (charShow == "Ice Cube") {

			IceCubeText ();

		}
		if (charShow == "Leafy") {

			LeafyText ();

		}
		if (charShow == "Lightning") {

			LightningText ();

		}
		if (charShow == "Liy") {

			LiyText ();

		}
		if (charShow == "Lollipop") {

			LollipopText ();

		}
		if (charShow == "Loser") {

			LoserText ();

		}
		if (charShow == "Marker") {

			MarkerText ();

		}
		if (charShow == "Match") {

			MatchText ();

		}
		if (charShow == "Naily") {

			NailyText ();

		}
		if (charShow == "Needle") {

			NeedleText ();

		}
		if (charShow == "Nickel") {

			NickelText ();

		}
		if (charShow == "Pen") {

			PenText ();

		}
		if (charShow == "Pencil") {

			PencilText ();

		}
		if (charShow == "Pie") {

			PieText ();

		}
		if (charShow == "Pillow") {

			PillowText ();

		}
		if (charShow == "Pin") {

			PinText ();

		}
		if (charShow == "Puffball") {

			PuffballText ();

		}
		if (charShow == "Remote") {

			RemoteText ();

		}
		if (charShow == "Robot Flower") {

			RobotFlowerText ();

		}
		if (charShow == "Roboty") {

			RobotyText ();

		}
		if (charShow == "Rocky") {

			RockyText ();

		}
		if (charShow == "Ruby") {

			RubyText ();

		}
		if (charShow == "Saw") {

			SawText ();

		}
		if (charShow == "Snowball") {

			SnowballText ();

		}
		if (charShow == "Spongy") {

			SpongyText ();

		}
		if (charShow == "Stapy") {

			StapyText ();

		}
		if (charShow == "Taco") {

			TacoText ();

		}
		if (charShow == "Teardrop") {

			TeardropText ();

		}
		if (charShow == "Tennis Ball") {

			TennisBallText ();

		}
		if (charShow == "Tree") {

			TreeText ();

		}
		if (charShow == "TV") {

			TVText ();

		}
		if (charShow == "Woody") {

			WoodyText ();

		}
		if (charShow == "Yellow Face") {

			YellowFaceText ();

		}

	}

	public void EightBallText(){

		title.text = "8-Ball";
		info.text = eightBallInfo;

	}
	public void BalloonyText(){

		title.text = "Balloony";
		info.text = balloonyInfo;

	}
	public void BarfBagText(){

		title.text = "Barf Bag";
		info.text = barfBagInfo;

	}
	public void BasketballText(){

		title.text = "Basketball";
		info.text = basketballInfo;

	}
	public void BellText(){

		title.text = "8-Ball";
		info.text = bellInfo;

	}
	public void BlackHoleText(){

		title.text = "Black Hole";
		info.text = blackHoleInfo;

	}
	public void BlockyText(){

		title.text = "Blocky";
		info.text = blockyInfo;

	}
	public void BombyText(){

		title.text = "Bomby";
		info.text = bombyInfo;

	}
	public void BookText(){

		title.text = "Book";
		info.text = bookInfo;

	}
	public void BottleText(){

		title.text = "Bottle";
		info.text = bottleInfo;

	}
	public void BraceletyText(){

		title.text = "Bracelety";
		info.text = braceletyInfo;

	}
	public void BubbleText(){

		title.text = "Bubble";
		info.text = bubbleInfo;

	}
	public void CakeText(){

		title.text = "Cake";
		info.text = cakeInfo;

	}
	public void ClockText(){

		title.text = "Clock";
		info.text = clockInfo;

	}
	public void CloudyText(){

		title.text = "Cloudy";
		info.text = cloudyInfo;

	}
	public void CoinyText(){

		title.text = "Coiny";
		info.text = coinyInfo;

	}
	public void DavidText(){

		title.text = "David";
		info.text = davidInfo;

	}
	public void DonutText(){

		title.text = "Donut";
		info.text = donutInfo;

	}
	public void DoraText(){

		title.text = "Dora";
		info.text = doraInfo;

	}
	public void EggyText(){

		title.text = "Eggy";
		info.text = eggyInfo;

	}
	public void EraserText(){

		title.text = "Eraser";
		info.text = eraserInfo;

	}
	public void FannyText(){

		title.text = "Fanny";
		info.text = fannyInfo;

	}
	public void FireyText(){

		title.text = "Firey";
		info.text = fireyInfo;

	}
	public void FireyJrText(){

		title.text = "Firey Jr";
		info.text = fireyJrInfo;

	}
	public void FlowerText(){

		title.text = "Flower";
		info.text = flowerInfo;

	}
	public void FoldyText(){

		title.text = "Foldy";
		info.text = foldyInfo;

	}
	public void FriesText(){

		title.text = "Fries";
		info.text = friesInfo;

	}
	public void GatyText(){

		title.text = "Gaty";
		info.text = gatyInfo;

	}
	public void GelatinText(){

		title.text = "Gelatin";
		info.text = gelatinInfo;

	}
	public void GolfBallText(){

		title.text = "Golf Ball";
		info.text = golfBallInfo;

	}
	public void GrassyText(){

		title.text = "Grassy";
		info.text = grassyInfo;

	}
	public void IceCubeText(){

		title.text = "Ice Cube";
		info.text = iceCubeInfo;

	}
	public void LeafyText(){

		title.text = "Leafy";
		info.text = leafyInfo;

	}
	public void LightningText(){

		title.text = "Lightning";
		info.text = lightningInfo;

	}
	public void LiyText(){

		title.text = "Liy";
		info.text = liyInfo;

	}
	public void LollipopText(){

		title.text = "Lollipop";
		info.text = lollipopInfo;

	}
	public void LoserText(){

		title.text = "Loser";
		info.text = loserInfo;

	}
	public void MarkerText(){

		title.text = "Marker";
		info.text = markerInfo;

	}
	public void MatchText(){

		title.text = "Match";
		info.text = matchInfo;

	}
	public void NailyText(){

		title.text = "Naily";
		info.text = nailyInfo;

	}
	public void NeedleText(){

		title.text = "Needle";
		info.text = needleInfo;

	}
	public void NickelText(){

		title.text = "Nickel";
		info.text = nickelInfo;

	}
	public void PenText(){

		title.text = "Pen";
		info.text = penInfo;

	}
	public void PencilText(){

		title.text = "Pencil";
		info.text = pencilInfo;

	}
	public void PieText(){

		title.text = "Pie";
		info.text = pieInfo;

	}
	public void PillowText(){

		title.text = "Pillow";
		info.text = pillowInfo;

	}
	public void PinText(){

		title.text = "Pin";
		info.text = pinInfo;

	}
	public void PuffballText(){

		title.text = "Puffball";
		info.text = puffballInfo;

	}
	public void RemoteText(){

		title.text = "Remote";
		info.text = remoteInfo;

	}
	public void RobotFlowerText(){

		title.text = "Robot Flower";
		info.text = robotFlowerInfo;

	}
	public void RobotyText(){

		title.text = "Roboty";
		info.text = robotyInfo;

	}
	public void RockyText(){

		title.text = "Rocky";
		info.text = rockyInfo;

	}
	public void RubyText(){

		title.text = "Ruby";
		info.text = rubyInfo;

	}
	public void SawText(){

		title.text = "Saw";
		info.text = sawInfo;

	}
	public void SnowballText(){

		title.text = "Snowball";
		info.text = snowballInfo;

	}
	public void SpongyText(){

		title.text = "Spongy";
		info.text = spongyInfo;

	}
	public void StapyText(){

		title.text = "Stapy";
		info.text = stapyInfo;

	}
	public void TacoText(){

		title.text = "Taco";
		info.text = tacoInfo;

	}
	public void TeardropText(){

		title.text = "Teardrop";
		info.text = teardropInfo;

	}
	public void TennisBallText(){

		title.text = "Tennis Ball";
		info.text = tennisBallInfo;

	}
	public void TreeText(){

		title.text = "Tree";
		info.text = treeInfo;

	}
	public void TVText(){

		title.text = "TV";
		info.text = tvInfo;

	}
	public void WoodyText(){

		title.text = "Woody";
		info.text = woodyInfo;

	}
	public void YellowFaceText(){

		title.text = "Yellow Face";
		info.text = yellowFaceInfo;

	}


}
