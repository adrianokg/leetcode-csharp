public class Solution {
    public string ReverseVowels(string s) {
        List<char> vowels = new List<char>();
        
        vowels.Add('A');
        vowels.Add('a');
        vowels.Add('E');
        vowels.Add('e');
        vowels.Add('I');
        vowels.Add('i');
        vowels.Add('O');
        vowels.Add('o');
        vowels.Add('U');
        vowels.Add('u');

        var result = s.ToCharArray();
        var i = 0;
        var j = s.Length - 1;

        while(i < j)
        {
            while (i < j && !vowels.Contains(result[i]))
                i++;

            while (i < j && !vowels.Contains(result[j]))
                j--;

            var temp = result[i];
            result[i] = result[j];
            result[j] = temp;
            i++;
            j--;
        }

        return new string(result);
    }
}
