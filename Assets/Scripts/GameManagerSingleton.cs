using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerSingleton : MonoBehaviour {
	public int numberOfPlayers = 2;

	private int currentPlayer;
	public Text playerListText;
	public Text currentPlayerText;
	public Text eventText;

	static List<Classes.Player> playerList;
	[SerializeField]
	public Material[] playerMaterialList;

	void Start () {
		playerList = new List<Classes.Player>(numberOfPlayers);
		for (int i = 0; i < numberOfPlayers; i++)
			playerList.Add (new Classes.Player (i+1));
		currentPlayer = 1;
		playerList [currentPlayer - 1].incrementGold ();



		getTexts (playerList);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void endTurn() {
		int goldIncrement;

		if (currentPlayer == numberOfPlayers)
			currentPlayer = 1;
		else
			currentPlayer += 1;

		goldIncrement = playerList [currentPlayer - 1].incrementGold ();
		Debug.Log ("Player " + currentPlayer + " gold incremented by: " + goldIncrement);
		Debug.Log ("Player " + currentPlayer + " gold: " + playerList [currentPlayer - 1].getPlayerGold());

		getTexts (playerList);
	}

	private void getTexts(List<Classes.Player> list){
		string text = "";
		foreach (Classes.Player player in list) {
			text += "Jogador " + player.getPlayerId ().ToString();
			text += ": " + player.getPlayerGold().ToString() + " ouro\n";
		}
		currentPlayerText.text = "Vez do jogador " + list[currentPlayer-1].getPlayerId().ToString() + "\nOuro: " + list[currentPlayer-1].getPlayerGold().ToString();
		playerListText.text = text;
	}

	public void alocateBuilding (GameObject building, string type, int level) {
		Renderer rend = building.GetComponent<Renderer>();
		rend.material = playerMaterialList[this.currentPlayer-1];
		if (playerList [currentPlayer - 1].addBuilding (building, type, level)) {
			Debug.Log ("Building built. Yay.");
			this.eventText.text = "Building built. Yay.";
			getTexts (playerList);
		} else {
			Destroy (building);
			Debug.Log ("Building destroyed. You're poor");
			this.eventText.text = "Building destroyed. You're poor";
		}
	}

	public void updateTexts() {
		getTexts (playerList);
	}
	public int getPlayerOffset() {
		return currentPlayer - 1; 
	}
}

