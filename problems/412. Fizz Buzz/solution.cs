public List<string> FizzBuzz(int n) {
    var result = new List<string>();
    
    for(var i = 1; i <= n; i++) {
        if (i % 3 == 00 && i % 5 == 00) {
            result.Add("FizzBuzz");
            continue;
        } else if (i % 3 == 0) {
            result.Add("Fizz");
            continue;
        } else if (i % 5 == 0) {
            result.Add("Buzz");
            continue;
        } 
        else
            result.Add(i.ToString());
    }
    
    return result;
}
