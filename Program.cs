
//Init start call a deck
Card[] deck = new Card[20];

//Console.WriteLine(card.value);


// Main body
Random rand = new Random();

for (int i = 0; i < deck.Length; i++)
{
    Suit suit = (Suit)rand.Next(0, (int)Suit.Count);
    int value = rand.Next(1, 13);
    deck[i] = new Card { suit = suit, value = value };
}


// Find a larges number
for (int i=0 ; i<(int)Suit.Count ; i++) {
  int largest = -1;

  foreach (Card card in deck) {
    // guard
    if ((int)card.suit != i) continue;

    if (card.value > largest) {
      largest = card.value;
    }
  }

  Console.WriteLine((Suit)i+": "+largest);
}



foreach (Card card in deck) {
  Console.WriteLine(card.value+" of "+card.suit);
}


// Data type

enum Suit
{
    Diamonds,
    Hearts,
    Spades,
    Clubs, Count
}

class Card {
  public int value;
  public Suit suit;
}
