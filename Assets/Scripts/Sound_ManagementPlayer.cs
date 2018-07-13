using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_ManagementPlayer : MonoBehaviour {

	public AudioSource audio;

	[Space]
	[Header("Pencil")]
	public AudioClip pencilWin;
	public AudioClip pencilPunch;
	public AudioClip pencilSpecial;
	public AudioClip pencilDies;

	[Space]
	[Header("Woody")]
	public List<AudioClip> woodyPunch;
	public AudioClip woodyDab;
	public AudioClip woodyWin;
	public AudioClip woodyLose;
	public AudioClip woodySpecial;
	public AudioClip woodyMock;
	public AudioClip woodyGag;

	[Space]
	[Header("Spongy")]
	public List<AudioClip> spongyPunch;
	public AudioClip spongyWin;
	public AudioClip spongyLose;
	public AudioClip spongyMock;
    public AudioClip spongySpecial;
    public AudioClip spongyWaterfall;
    public AudioClip spongySplash;

    [Space]
    [Header("Pen")]
    public List<AudioClip> penPunch;
    public AudioClip penWin, penLose, penMock, penSpecial, penMiniSpecial;

	//PENCIL
	public void PencilWin(){

		audio.PlayOneShot (pencilWin);

	}
	public void PencilPunch(){

		audio.PlayOneShot (pencilPunch);

	}
	public void PencilSpecial(){

		audio.PlayOneShot (pencilSpecial);

	}
	public void PencilDies(){

		audio.PlayOneShot (pencilDies);

	}

	//WOODY
	public void WoodyPunch(){

		int randomize = Random.Range (0, woodyPunch.Count);
		AudioClip punch = woodyPunch [randomize];
		audio.PlayOneShot (punch);

	}
	public void WoodyDab(){

		audio.PlayOneShot (woodyDab);

	}
	public void WoodyWin(){

		audio.PlayOneShot (woodyWin);

	}
	public void WoodyLose(){

		audio.PlayOneShot (woodyLose);

	}
	public void WoodySpecial(){

		audio.PlayOneShot (woodySpecial);

	}
	public void WoodyMock(){

		audio.PlayOneShot (woodyMock);

	}
	public void WoodyGag(){

		audio.PlayOneShot (woodyGag);

	}

	//SPONGY
	public void Sound_SpongyPunch(){

		int randomize = Random.Range (0, spongyPunch.Count);
		AudioClip punch = spongyPunch [randomize];
		audio.PlayOneShot (punch);

	}
	public void Sound_SpongyWin(){

		audio.PlayOneShot (spongyWin);

	}
	public void Sound_SpongyLose(){

		audio.PlayOneShot (spongyLose);

	}
	public void Sound_SpongyMock(){

		audio.PlayOneShot (spongyMock);

	}
	public void Sound_SpongySpecialWaterFall(){

		audio.PlayOneShot (spongyWaterfall);

    }
    public void Sound_SpongySpecial()
    {

        audio.PlayOneShot(spongySpecial);

    }
    public void Sound_SpongySpecialSplash()
    {

        audio.PlayOneShot(spongySplash);

    }

    //PEN
    public void Sound_PenPunch()
    {

        int randomize = Random.Range(0, penPunch.Count);
        AudioClip punch = penPunch[randomize];
        audio.PlayOneShot(punch);

    }
    public void Sound_PenWin(){

        audio.PlayOneShot(penWin);

    }
    public void Sound_PenLose()
    {

        audio.PlayOneShot(penLose);

    }
    public void Sound_PenSpecial()
    {

        audio.PlayOneShot(penSpecial);

    }
    public void Sound_PenMiniSpecial()
    {

        audio.PlayOneShot(penMiniSpecial);

    }
    public void Sound_PenMock(){

        audio.PlayOneShot(penMock);

    }
}
