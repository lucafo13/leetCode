public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> sol = new List<string>();
        for(int i = 1; i <= n; i++)
        {
            bool d3 = (i % 3 == 0);
            bool d5 = (i % 5 == 0);

            if(!d3 && d5)
            {
                sol.Add("Buzz");
            }
            if(d3 && !d5)
            {
                sol.Add("Fizz");
            }
            if(d3 && d5)
            {
                sol.Add("FizzBuzz");
            }
            if(!d3 && !d5)
            {
                sol.Add($"{i}");
            }
        }
        return sol;
    }
}