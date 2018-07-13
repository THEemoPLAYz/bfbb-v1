using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Characterselect_ControllerVer3 : MonoBehaviour {

    public Animator currentselectingPlayer1, currentselectingPlayer2;
    public GameObject mainCam, playerSelectCam, exitCam;
    public string stateOfDoing;

    [Header("Teams")]
    public GameObject beep;
    public GameObject betterName, blawowa, deathPact, freeFood, iance, iceCube, losers;

    [Header("Panels")]
    public GameObject teamPanel;
    public GameObject characterPanel;
    public GameObject infoPanel;


    [Header("Group")] //Groups are insides of panels
    public GameObject beepGroup;
    public GameObject betternameGroup, blawowaGroup, deathpactGroup, freefoodGroup, ianceGroup, icecubeGroup, losersGroup;

    [Header("Icons")]
    public List<Sprite> Icons;

    [Header("UI Elements")]
    public Image player1;
    public Image player2;
    public TextMeshProUGUI text1, text2;
    public Dropdown controller1, controller2;

    private Sprite selectImage;
    private string selectText;

    [Header("Storage Dump")]
    public GameObject storage;

    [Header("Miscellaneous")]
    public GameObject keyInstructions;
    public GameObject confirmButton, blackOverlay;

	// Use this for initialization
	void Start () {

        resetPlayerSelectPanel();
        stateOfDoing = "nothing";
    }
	
	// Update is called once per frame
	void Update () {

        updateStorageDump();
        checkAllSelected();

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            closeselecting();

        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {

            if(teamPanel.activeSelf == true)
            {

                closeselecting();

            }
            else if(characterPanel.activeSelf == true)
            {

                resetPlayerSelectPanel();
                teamPanel.SetActive(true);

            }


        }

	}
    public void confirmSelection()
    {

        exitCam.SetActive(true);
        StartCoroutine(LoadPlay());

    }
    IEnumerator LoadPlay()
    {

        yield return new WaitForSeconds(5f);
        blackOverlay.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadSceneAsync("Play_EvilForest");


    }

    public void checkAllSelected()
    {
        string checktext1 = storage.GetComponent<CharacterSelect_StorageDump>().selectedChar1;
        string checktext2 = storage.GetComponent<CharacterSelect_StorageDump>().selectedChar2;
        int controller1 = storage.GetComponent<CharacterSelect_StorageDump>().selectedController1;
        int controller2 = storage.GetComponent<CharacterSelect_StorageDump>().selectedController2;

        if (checktext1 != "player 1" && checktext2 != "player 2" && controller1 != 0 && controller2 != 0)
        {

            confirmButton.SetActive(true);

        }
        else
        {

            confirmButton.SetActive(false);

        }

    }
    public void updateStorageDump()
    {

        storage.GetComponent<CharacterSelect_StorageDump>().selectedChar1 = text1.text;
        storage.GetComponent<CharacterSelect_StorageDump>().selectedChar2 = text2.text;
        storage.GetComponent<CharacterSelect_StorageDump>().selectedController1 = controller1.value;
        storage.GetComponent<CharacterSelect_StorageDump>().selectedController2 = controller2.value;

    }

    public void currentselecting1()
    {

        currentselectingPlayer1.SetBool("Selecting", true);
        currentselectingPlayer2.SetBool("Selecting", false);
        mainCam.SetActive(false);
        playerSelectCam.SetActive(true);
        makeSureAllPanelsClosed();
        stateOfDoing = "selecting player1";

    }
    public void currentselecting2()
    {

        currentselectingPlayer1.SetBool("Selecting", false);
        currentselectingPlayer2.SetBool("Selecting", true);
        mainCam.SetActive(false);
        playerSelectCam.SetActive(true);
        makeSureAllPanelsClosed();
        stateOfDoing = "selecting player2";

    }
    public void makeSureAllPanelsClosed()
    {
        if (teamPanel.activeSelf == false && characterPanel.activeSelf == false)
        {

            teamPanel.SetActive(true);
            keyInstructions.SetActive(true);

        }

    }
    public void closeselecting()
    {

        currentselectingPlayer1.SetBool("Selecting", false);
        currentselectingPlayer2.SetBool("Selecting", false);
        mainCam.SetActive(true);
        playerSelectCam.SetActive(false);
        resetPlayerSelectPanel();
        stateOfDoing = "nothing";
        infoPanel.GetComponent<infoPanelManager>().showingInfo = "";

    }
    public void disableAllTeams()
    {

        beep.SetActive(false);
        betterName.SetActive(false);
        blawowa.SetActive(false);
        deathPact.SetActive(false);
        freeFood.SetActive(false);
        iance.SetActive(false);
        iceCube.SetActive(false);
        losers.SetActive(false);

    }
    public void disableAllGroups()
    {

        beepGroup.GetComponent<GroupManager>().disableTeammates();
        beepGroup.SetActive(false);

        betternameGroup.GetComponent<GroupManager>().disableTeammates();
        betternameGroup.SetActive(false);

        blawowaGroup.GetComponent<GroupManager>().disableTeammates();
        blawowaGroup.SetActive(false);

        deathpactGroup.GetComponent<GroupManager>().disableTeammates();
        deathpactGroup.SetActive(false);

        freefoodGroup.GetComponent<GroupManager>().disableTeammates();
        freefoodGroup.SetActive(false);

        ianceGroup.GetComponent<GroupManager>().disableTeammates();
        ianceGroup.SetActive(false);

        icecubeGroup.GetComponent<GroupManager>().disableTeammates();
        icecubeGroup.SetActive(false);

        losersGroup.GetComponent<GroupManager>().disableTeammates();
        losersGroup.SetActive(false);

    }
    public void resetPlayerSelectPanel()
    {

        disableAllGroups();
        disableAllTeams();
        characterPanel.SetActive(false);
        teamPanel.SetActive(false);
        infoPanel.SetActive(false);
        keyInstructions.SetActive(false);

    }
    public void teamSelect_Beep()
    {

        teamPanel.SetActive(false);
        characterPanel.SetActive(true);
        beepGroup.SetActive(true);

    }
    public void teamSelect_BetterName()
    {

        teamPanel.SetActive(false);
        characterPanel.SetActive(true);
        betternameGroup.SetActive(true);

    }
    public void teamSelect_Blawowa()
    {

        teamPanel.SetActive(false);
        characterPanel.SetActive(true);
        blawowaGroup.SetActive(true);

    }
    public void teamSelect_DeathPact()
    {

        teamPanel.SetActive(false);
        characterPanel.SetActive(true);
        deathpactGroup.SetActive(true);

    }
    public void teamSelect_FreeFood()
    {

        teamPanel.SetActive(false);
        characterPanel.SetActive(true);
        freefoodGroup.SetActive(true);

    }
    public void teamSelect_Iance()
    {

        teamPanel.SetActive(false);
        characterPanel.SetActive(true);
        ianceGroup.SetActive(true);

    }
    public void teamSelect_IceCube()
    {

        teamPanel.SetActive(false);
        characterPanel.SetActive(true);
        icecubeGroup.SetActive(true);

    }
    public void teamSelect_Losers()
    {

        teamPanel.SetActive(false);
        characterPanel.SetActive(true);
        losersGroup.SetActive(true);

    }
    
    public void showInformation(string characterName)
    {

        infoPanel.SetActive(false);
        infoPanel.GetComponent<infoPanelManager>().showingInfo = characterName;
        infoPanel.SetActive(true);

    }
    public void selectCharacter()
    {

        string select = infoPanel.GetComponent<infoPanelManager>().showingInfo;

        for (int i = 0; i < Icons.Count; i++)
        {

            if (Icons[i].name == select)
            {

                selectImage = Icons[i];
                selectText = Icons[i].name;

                break;
            }

        }

        if(stateOfDoing == "selecting player1")
        {

            player1.sprite = selectImage;
            text1.text = selectText;
            RefreshPlayer1();

        }else if (stateOfDoing == "selecting player2")
        {

            player2.sprite = selectImage;
            text2.text = selectText;
            RefreshPlayer2();

        }

        closeselecting();

    }
    public void RefreshPlayer1()
    {

        player1.gameObject.SetActive(false);
        player1.gameObject.SetActive(true);

    }
    public void RefreshPlayer2()
    {

        player2.gameObject.SetActive(false);
        player2.gameObject.SetActive(true);

    }
    public void SaveSelection()
    {

        storage.GetComponent<CharacterSelect_StorageDump>().selectedChar1 = text1.text;
        storage.GetComponent<CharacterSelect_StorageDump>().selectedChar2 = text2.text;

    }
}
