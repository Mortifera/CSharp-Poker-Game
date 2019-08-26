﻿using System;
using System.Linq;
using NUnit.Framework;

namespace CardLibrary.UnitTests
{
    [TestFixture]
    class DeckTests
    {
        /// <summary>
        /// Retrieves a test deck. 
        /// </summary>
        /// <returns>Returns a card set.</returns>
        private Deck GetTestDeck()
        {
            return new Deck();
        }

        [Test]
        public void Deck_IsValid_ReturnsTrue()
        {
            Deck testDeck = GetTestDeck();
            int cardCount = 13;
            int totalClubCards = testDeck.Count(card => card.Suit == Suit.Club);
            int totalDiamondCards = testDeck.Count(card => card.Suit == Suit.Diamond);
            int totalHeartCards = testDeck.Count(card => card.Suit == Suit.Heart);
            int totalSpadeCards = testDeck.Count(card => card.Suit == Suit.Spade);

            bool isValidDeck = totalClubCards == cardCount && 
                          totalDiamondCards == cardCount && 
                          totalHeartCards == cardCount && 
                          totalSpadeCards == cardCount;

            Assert.That(isValidDeck);

        }

    }
}
