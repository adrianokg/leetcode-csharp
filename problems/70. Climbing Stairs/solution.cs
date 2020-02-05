public int ClimbStairs(int n) {
    if (n == 0)
        return 0;
    else if (n == 1)
        return 1;
    else if (n == 2)
        return 2;
    else
    {
        int n1 = 1, n2 = 2;
        int result = 0;

        while (n-- > 2)
        {
            result = n1 + n2;
            n1 = n2;
            n2 = result;
        }

        return result;
    }
}
