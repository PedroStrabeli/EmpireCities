using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Classes
{
	public class Player {
		int gold;
		int id;
		int totalBuildings;//
		int currentResNumber = 0;
		int currentMilNumber = 0;
		int currentRelNumber = 0;
		static List<Classes.Building> buildingList;

		public Player(int id) {
			this.gold = 0;
			this.id = id;
		}

		public int incrementGold() {
			int increment = (int)Random.value * 1000 + 1000;
			this.gold += increment;

			return increment;
		}

		public int getPlayerGold() {
			return this.gold;
		}

		public int getPlayerId() {
			return this.id;
		}

		public int spendGold(int spent){
			this.gold -= spent;
			return this.gold;
		}

		public void addBuilding (string type, int level) {
			switch (type) {
			case "res":
				currentResNumber++;
			break;
			case "mil":
				currentMilNumber++;
			break;
			case "rel":
				currentRelNumber++;
			break;
			} 
			Building newb = new Building (type, 1);
			spendGold (newb.cost);
			//GameManagerSingleton.updateTexts ();
			buildingList.Add (new Classes.Building (type, level));
			//spendGold (buildingList.LastOrDefault().cost);
		}
	}
}

