using System;
using System.Collections.Generic;

namespace MaxLengthProd
{
    public class maxwordlenthprod
    {
        private bool doshareletters(string s1, string s2,out HashSet<char> wwcl)
        {
            wwcl=new HashSet<char>();
            foreach (char t in s1)
            {
                if (!wwcl.Contains(t))
                    wwcl.Add(t);
            }
            foreach (char t in s2)
            {
                if (wwcl.Contains(t))
                    return true;
            }
            return false;
        }
        public int findmaxlenprod(string[] words)
        {
            var maxpair=new WordPair(null,null);
            int p2;
            for (int p1 = 0; p1 < words.Length - 2; p1++)
            {
                p2 = 1;
                do
                {
                   if (words[p1] != words[p2])
                    {
                        HashSet<char> wordswithcommonletters;
                        if (!doshareletters(words[p1], words[p2], out wordswithcommonletters))
                        {
                            var currentPair = new WordPair(words[p1], words[p2]);
                            if (currentPair.Lengthprod > maxpair.Lengthprod)
                            {
                                maxpair = currentPair;
                            }
                        }
                        
                    }
                    p2++;
                } while (p2 < words.Length - 1);
            }

            if (maxpair.Lengthprod != 0)
            {
                Console.WriteLine(maxpair.Word1, maxpair.Word2);
                return maxpair.Lengthprod;
            }
            else
                return 0;
        }
    }
}
