using UnityEngine;
using System.Collections;

public class KeepPlayersOrganized : MonoBehaviour {

	public float playerSpacing;
	public OrganizedPlayer[] players;

	public float tweenSpeed = 1f;

	public void Start() {
		RandomizePlayers();
		ReorganizePlayers();
	}

	void RandomizePlayers() {
		for( int index = 0; index < players.Length; index++ ) {
	        OrganizedPlayer temp = players[index];
	        int randomIndex = Random.Range(index, players.Length);
	        players[index] = players[randomIndex];
	        players[randomIndex] = temp;
	    }
	}

	void ReorganizePlayers() {
		for( int index = 0; index < players.Length; index++ ) {
			players[index].MoveToLocalPosition( -index * playerSpacing );
		}
	}

	public void MovePlayerToEndOfList( OrganizedPlayer playerToMove ) {

		int indexOfPlayerToMove = -1;
		for( int index = 0; index < players.Length; index++ ) {
			if( players[index] == playerToMove ) indexOfPlayerToMove = index;
		}

		if( indexOfPlayerToMove != -1 ) {
			for( int index = indexOfPlayerToMove + 1; index < players.Length; index++ ) {
				players[index - 1] = players[index];
			}

			players[players.Length - 1] = playerToMove;
		}

		ReorganizePlayers();
	}
}
