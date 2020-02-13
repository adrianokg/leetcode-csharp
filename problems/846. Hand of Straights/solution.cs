public bool IsNStraightHand(int[] hand, int W) {
    if (hand.Length % W != 0)
        return false;

    SortedDictionary<int, int> cardCounts = new SortedDictionary<int, int>();

    foreach(var card in hand)
    {
        if (!cardCounts.ContainsKey(card))
            cardCounts.Add(card, 1);
        else
        {
            var cont = cardCounts.GetValueOrDefault(card) + 1;
            cardCounts.Remove(card);
            cardCounts.Add(card, cont);
        }
    }

    while(cardCounts.Count > 0)
    {
        int minValue = cardCounts.Keys.First();

        for (int card = minValue; card < minValue + W; card++)
        {
            if (!cardCounts.ContainsKey(card))
                return false;

            int count = cardCounts.GetValueOrDefault(card);

            if (count == 1)
                cardCounts.Remove(card);
            else
            {
                var cont2 = cardCounts.GetValueOrDefault(card) - 1;
                cardCounts.Remove(card);
                cardCounts.Add(card, cont2);
            }
        }
    }

    return true;
}
