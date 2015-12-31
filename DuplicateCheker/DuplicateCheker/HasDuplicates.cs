using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateCheker
{
    public class HasDuplicates
    {
        private void isValid(int[] a)
        {
            if((a==null) || (a.Length==0))
                throw new ArgumentException();
        }

        public bool ContainDuplicates(int[] input)
        {
            isValid(input);
            HashSet<int> elements=new HashSet<int>();
            foreach (var i in input)
            {
                if (elements.Contains(i))
                    return true;
                else
                    elements.Add(i);
                
            }
            return false;
        }
            
    }
}
