using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumNumber
{
    public class MaxNumber<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public MaxNumber(T fValue, T sValue, T tValue)
        {
            firstValue = fValue;
            secondValue = sValue;
            thirdValue = tValue;
        }
        public T Max()
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
             
            return default;

        }
    }
}
   
