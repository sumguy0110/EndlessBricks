using System.Linq;
using UnityEngine;
using System.Collections;

// What is being used in this script?  Why?

public class Advanced_17 : MonoBehaviour {

	public Card[] cards;

	void Method() {
		var ordCards = cards.Where(t => t.cardType == Card.CardTypes.Item).OrderBy(n => n.manaCost).Select(c => string.Format("- {0}: {1}", c.manaCost, c.cardName));

		ordCards.ToList().ForEach( e => print(e) );
	}
}

public class Card {
	public string cardName = "";

	public int manaCost;

	public enum CardTypes { Item, Spell, Character, Confused_Student }
	public CardTypes cardType;
}
