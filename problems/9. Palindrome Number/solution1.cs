public bool IsPalindrome(int x)
{
    if (x < 0)
        return false;

    if (x >= 0 && x < 10)
        return true;
    else
    {
        string number = x.ToString();
        char[] charArray = number.ToCharArray();
        Array.Reverse(charArray);
        
        if (number == new string(charArray))
            return true;
        else
            return false;
    }
}