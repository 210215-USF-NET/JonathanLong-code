using System;
using System.Collections;
using System.Collections.Generic;
namespace CalcApp
{
    public class CalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {int.MinValue, -1, int.MaxValue};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
      
    }
}