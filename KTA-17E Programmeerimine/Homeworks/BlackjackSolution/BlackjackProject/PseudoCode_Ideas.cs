using System;
using System.Collections.Generic;
using System.Text;

namespace BlackjackProject
{
    class PseudoCode_Ideas
    {
        /* 
         * 
         * Different classes for: 
         * 1. Deck
         * 2. Dealer
         * 3. Player
         * 4. Program (main method, communicate with the player)
         * (maybe a separate class for Hand? containing the cards currently in hand)
         * (maybe a gameController class also?? we'll see)
         * 
         * The deck class should take 2 enums to work with:
         * one for the numbers + jack, queen, king, ace and one for Suit ♠♥♦♣
         * 
         * Program logic:
         * fill the 52? card deck using for cycles?
         * shuffle the deck
         * deal the cards to dealer and player (need to take the cards out of the list so they wouldnt repeat)
         * display the dealt hands for player and dealer(second card hidden for dealer)
         * ask (cycle) the user what they want to do next (1 to hit, 2 to reveal/end)
         * if hit again, deal another card from our deck (but what about house??? - hit aswell when user hits?, hmm...)
         * if end, decide the winner and reveal the results
         * 
        */

        /*
         * Copy-paste from a blackjack rulebook about some rules
         * 
         * Object of the Game
         * Each participant attempts to beat the dealer by getting a count as close to 21 as possible, without going over 21.
         * 
         * The Dealer's Play
         * When the dealer has served every player, his face-down card is turned up. 
         * If the total is 17 or more, he must stand. If the total is 16 or under, he must take a card. 
         * He must continue to take cards until the total is 17 or more, at which point the dealer must stand. 
         * If the dealer has an ace, and counting it as 11 would bring his total to 17 or more (but not over 21), he must count the ace as 11 and stand. 
         * The dealer's decisions, then, are automatic on all plays, whereas the player always has the option of taking one or more cards.
         * 
         * Card Values/Scoring
         * It is up to each individual player if an ace is worth 1 or 11. Face cards are 10 and any other card is its pip value.
         */
    }
}
