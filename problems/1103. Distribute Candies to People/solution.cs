public int[] DistributeCandies(int candies, int num_people) {
    var distributed = new int[num_people];
    var count = 0;
    var numCandies = 1;

    while (candies > 0)
    {
        if (numCandies <= candies)
        {
            distributed[count] += numCandies;
        } 
        else
        {
            distributed[count] += candies;
        }

        count++;
        
        if (count == num_people)
        {
            count = 0;
        }

        candies -= numCandies;
        numCandies++;
    }

    return distributed;
}
