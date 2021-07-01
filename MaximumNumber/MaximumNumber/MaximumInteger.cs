using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    public class MaxNumber
    {
        public T Max<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
               firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
                return firstValue;
        
        
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
                return secondValue;
        
        
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
                return thirdValue;
            throw new Exception("All values are same");

        }
    }
}
   
