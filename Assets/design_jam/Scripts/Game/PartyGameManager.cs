using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PartyGameManager : GameManager {
	//public static PartyGameManager instance;

	public void AdvanceTurn(){
		var stuff = InterfaceHelper.FindObjects<ITurnChangeGeneric>();
		foreach (var item in stuff) {
			item.TurnChange ();
		}
	}

	public override void  generatePlayers() {
		PlayerBoat player;

		player = ((GameObject)Instantiate(UserPlayerPrefab, new Vector3(0 - Mathf.Floor(mapSize/2),1.5f, -0 + Mathf.Floor(mapSize/2)), Quaternion.Euler(new Vector3()))).GetComponent<PlayerBoat>();

		players.Add(player);

	}

}
