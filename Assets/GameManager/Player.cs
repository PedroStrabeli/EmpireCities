using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classes
{
	public class Player {
		int gold;
		int id;

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
	}
}

