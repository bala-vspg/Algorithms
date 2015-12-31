using System.Collections.Generic;

namespace MajorityElementChecker
{//find teh majority element in the array. MajorityELment=occurs morethan n/2 times.
    //Question - what if we have more than one majority element? can i return an array or stack which has the collection of such elements - ?
    public class MajorityElement
    {
        public int FindMajorityElement(int[] input)
        {
            Dictionary<int,int> occuranceCounter=new Dictionary<int, int>();
            foreach (var i in input)
            {
                if (occuranceCounter.ContainsKey(i))
                {
                    occuranceCounter[i]++;
                    if (occuranceCounter[i] > (input.Length/2))
                        return i;
                }
                else
                {
                    occuranceCounter.Add(i,1);
                }
                   
            }
            return 0;
        }
    }
}
