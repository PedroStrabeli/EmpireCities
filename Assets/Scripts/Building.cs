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

		public Building (string type, int level) {
			this.type = type;
			this.level = level;
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

