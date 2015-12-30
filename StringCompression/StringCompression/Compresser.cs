using System;
using System.Text;

namespace StringCompression
{
   public class Compress
    {
        private void isValid(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException();
        }

        public string CompressGivenString(string input)
        {
            isValid(input);

            StringBuilder sb = new StringBuilder();
            int count = 1;
            
            for(int candidate=0,current=candidate+1;candidate<input.Length;)
            {
                if((current<input.Length) && (input[candidate] ==input[current]))
                {
                    count++;
                    current++;
        
                }
                else
                {
                    sb.Append(input[candidate]);
                    sb.Append(count);
                    count = 0;
                    candidate = current;
                }
                
            }
            if (input.Length >= sb.ToString().Length)
                return sb.ToString();
            else
                return input;
        }
    }
}
