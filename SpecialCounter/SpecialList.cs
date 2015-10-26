using System.Collections.Generic;

namespace SpecialCounter
{
    public class SpecialList
    {
        public Dictionary<int, string> CounterHighlights { get; set; } = new Dictionary<int, string>() { { 3, "Fizz" }, { 5, "Buzz" } };

        public int Max { get; set; } = 100;

        public Dictionary<int, string> Generate()
        {
            Dictionary<int, string> output = new Dictionary<int, string>();
            for (var i = 1; i <= Max; i++)
            {
                var foundatleastone = false;
                var outputstring = string.Empty;
                foreach (var pair in CounterHighlights)
                {
                    if (i % pair.Key == 0)
                    {
                        outputstring += foundatleastone ? " " + pair.Value : pair.Value;  
                        foundatleastone = true;
                    }
                }
                outputstring = foundatleastone ? outputstring : i.ToString();
                output.Add(i,outputstring);
            }
            return output;
        }
    }
}
