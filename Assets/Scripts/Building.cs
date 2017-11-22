using System;
using UnityEngine;

namespace Classes
{
	public class Building
	{
		int playerId;
		public int cost;
		string type;
		int level;
		GameObject instance;

		public Building (GameObject building, string type, int level) {
			this.type = type;
			this.level = level;
			instance = building;
			switch (level) {
			case 1:
				cost = 4000;
			break;
			case 2:
				cost = 7000;
			break;
			case 3:
				cost = 10000;
			break;
			}
		}
	}
}

