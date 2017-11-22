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
			buildingList = new List<Classes.Building>();
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

		public bool addBuilding (GameObject building, string type, int level) {
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

			Building newb = new Building (building, type, 1);
			if (this.gold >= newb.cost) {
				spendGold (newb.cost);
				buildingList.Add (newb);
				return true;
			} else
				return false;
		}

		//public List<Classes.Building> getbuildingColision(Ray ray, RaycastHit hitInfo){
			//foreach (Building building in this.buildingList) {
				//if (Physics.Raycast (ray, out hitInfo)) {
				//	hitInfo.point;
				//}
			//}
		//}

	}
}

