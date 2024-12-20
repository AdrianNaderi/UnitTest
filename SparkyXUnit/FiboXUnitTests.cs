﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class FiboXUnitTests
    {
        private Fibo _fibo;

        public FiboXUnitTests()
        {
            _fibo = new Fibo();
        }

        [Fact]
        public void FiboChecker_Input1_ReturnsFiboSeries()
        {
            List<int> expectedRange = new() { 0 };

            _fibo.Range = 1;

            List<int> result = _fibo.GetFiboSeries();

            Assert.NotEmpty(result);
            Assert.Equal(expectedRange.OrderBy(x=> x), result);
            Assert.True(result.SequenceEqual(expectedRange));
        }

        [Fact]
        public void FiboChecker_Input6_ReturnsFiboSeries()
        {
            List<int> expectedRange = new() { 0, 1, 1, 2, 3, 5 };

            _fibo.Range = 6;

            List<int> result = _fibo.GetFiboSeries();

            Assert.Contains(3, result);
            Assert.Equal(6, result.Count);
            Assert.DoesNotContain(4, result);
            Assert.Equal(expectedRange,result);
        }
    }
}