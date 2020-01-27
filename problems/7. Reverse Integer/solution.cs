public int Reverse(int number) {
    long revertedNumber = 0;
    var signal = 1;

    if(number < 0)
    {
        number *= -1;
        signal = -1;
    }

    while (number > 0)
    {
        if (revertedNumber * 10 < Int32.MaxValue)
            revertedNumber = revertedNumber * 10 + number % 10;
        else
            return 0;

        number /= 10;
    }

    return (int) revertedNumber * signal;
}