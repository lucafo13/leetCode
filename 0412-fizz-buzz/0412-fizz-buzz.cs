using System.Linq;
using System.Collections.Generic;
public class Solution {
    public IList<string> FizzBuzz(int n) {
 
       
        return Enumerable.Range(1, n).Select(i => i % 15 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString()).ToArray();
    }
}