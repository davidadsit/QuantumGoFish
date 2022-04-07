# QuantumGoFish
Instructions for the Quantum Go Fish kata

Quantum Go Fish is a logic game where you are trying to capture a full set of "cards". 
The twist? 
None of the cards are defined at the beginning of the game.

## Rules

At the beginning of the game, each player starts with four blank cards.
Eventually, these cards will be defined as belonging to suits.
There are as many suits as there are players in the game, so each suit must have exactly four cards.

On a given players turn, they must ask one of their opponents "Do you have any ____s?"
The player may only ask for cards that they already posess a copy of.
The opponent may answer yes, and turn over a single copies of that suit they hold, or no.
If the opponent has two copies of that suit, they still only give one to the player.
They must answer truthfully.

There are two ways to win the game.
The first way is to gather (and be able to prove that you have) all four cards of any suit.
The second is to be able to define every card that all players have.

On the other hand, you lose if you ever break the reality of the game.
The most common way to do this is to cause 5 cards of any suit to exist in players hands.
If this happens, the player who caused the break loses.

## Example

Blue, Green, and Red are playing a game of Quantum Go Fish.
All four start with 4 blank cards.
Blue goes first.

Blue asks Green "Do you have any Narwhals?"
This means that Blue has at least one Narwhal.

Green responds "No".
This means that all four of Green's cards are not Narwhals.
This is valid because there are still more than 3 cards that an still be Narwhals.

The state after Blue's turn is:

Blue - Narwhal ??? ??? ???
Green - (Not Narwhal) (Not Narwhal) (Not Narwhal) (Not Narwhal)
Red - ??? ??? ??? ???

On Green's turn, Green asks Red "Do you have any butterflies?"
Red says "Yes", and gives Green a Butterfly.

The state after Green's turn is:

Blue - Narwhal ??? ??? ???
Green - Butterfly Butterfly (Not Narwhal) (Not Narwhal) (Not Narwhal)
Red - ??? ??? ???

On Red's turn, Red asks Green "Do you have any turtles?"
This defines the final suit for the game.
If Green were to say no, they would lose, because it would mean that all of their cards would be butterflies, but only 4 butterflies can exist.

Green says yes, and gives one of their cards to Red.

The state after Red's turn is:

Blue - Narwhal ??? ??? ???
Green - Butterfly Butterfly (Not Narwhal) (Not Narwhal)
Red - Turtle Turtle ??? ???

On Blue's next turn, they ask Red "Do you have any Narwhals?"
If Red says no, then Blue will win, because Blue will have the only cards that can be Narwhals.
Red says "yes", and gives blue a Narwhal.

The state after Blue's turn is:

Blue - Narwhal Narwhal ??? ??? ???
Green - Butterfly Butterfly (Not Narwhal) (Not Narwhal)
Red - Turtle Turtle ??? 

On Green's turn, Green asks Blue "Do you have any Turtles?"
Blue says "Yes", and gives a Turtle to Green.
Because Green must have a Turtle to ask this, all four turtles are accounted for.
This means that Green's last card must be a Butterfly, since it can be neither a Narwhal nor a Turtle.

The state after Green's turn is: 

Blue - Narwhal Narwhal ??? ???
Green - Butterfly Butterfly Butterfly Turtle Turtle
Red - Turtle Turtle ??? 

On Red's turn, Red asks Blue "Do you have any butterflies?"
This makes Red's third card a butterfly, which is the last butterfly.
Blue must answer "no"
Because this means that all cards are accounted for, Red wins by explaining what everyone's cards are.

The state after Red's turn is:

Blue - Narwhal Narwhal Narwhal Narwhal
Green - Butterfly Butterfly Butterfly Turtle Turtle
Red - Turtle Turtle Butterfly