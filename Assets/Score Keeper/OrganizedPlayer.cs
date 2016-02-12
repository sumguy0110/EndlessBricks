using UnityEngine;
using System.Collections;

public class OrganizedPlayer : MonoBehaviour {

	public RectTransform rectTransform;
	public KeepPlayersOrganized playerOrganizer;

	float targetYPos = -1f;
	float startYPos = -1f;
	float interpolatedTime = 0f;

	public void MoveToLocalPosition( float yPos ) {
		startYPos = rectTransform.anchoredPosition.y;
		targetYPos = yPos;
	}

	void Update() {
		if( rectTransform.anchoredPosition.y != targetYPos ) {
			interpolatedTime += Time.deltaTime * playerOrganizer.tweenSpeed;

			rectTransform.anchoredPosition = new Vector2( 0f, Mathf.Lerp( startYPos, targetYPos, interpolatedTime ) );
		}
		else {
			interpolatedTime = 0f;
		}
	}

	public void ScoreFieldUpdated( string updatedScore ) {
		playerOrganizer.MovePlayerToEndOfList( this );
	}
}
