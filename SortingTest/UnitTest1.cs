using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingLab1;

namespace SortingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SortWithoutRest()
        {
            const int count = 10000;
            var sort = new SimultaneousInsertionSort<Data>(5);
            var dataArrGen = new DataArrayGenerator();
            var sourceArr = dataArrGen.Generate(count);
            var exp = new Data[count];
            Array.Copy(sourceArr, exp, sourceArr.Length);

            Array.Sort(exp);
            var actual = sort.Sort(sourceArr);

            CollectionAssert.AreEqual(exp, actual.ToArray());
        }

        [TestMethod]
        public void SortWithRest()
        {
            const int count = 10000;
            var sort = new SimultaneousInsertionSort<Data>(7);
            var dataArrGen = new DataArrayGenerator();
            var sourceArr = dataArrGen.Generate(count);
            var exp = new Data[count];
            Array.Copy(sourceArr, exp, sourceArr.Length);

            Array.Sort(exp);
            var actual = sort.Sort(sourceArr);

            CollectionAssert.AreEqual(exp, actual.ToArray());
        }

        [TestMethod]
        public void SortByOneElemInGroup()
        {
            const int count = 10000;
            var sort = new SimultaneousInsertionSort<Data>(1);
            var dataArrGen = new DataArrayGenerator();
            var sourceArr = dataArrGen.Generate(count);
            var exp = new Data[count];
            Array.Copy(sourceArr, exp, sourceArr.Length);

            Array.Sort(exp);
            var actual = sort.Sort(sourceArr);

            CollectionAssert.AreEqual(exp, actual.ToArray());
        }

        [TestMethod]
        public void SortOneElement()
        {
            const int count = 1;
            var sort = new SimultaneousInsertionSort<Data>(1);
            var dataArrGen = new DataArrayGenerator();
            var sourceArr = dataArrGen.Generate(count);
            var exp = new Data[count];
            Array.Copy(sourceArr, exp, sourceArr.Length);

            Array.Sort(exp);
            var actual = sort.Sort(sourceArr);

            CollectionAssert.AreEqual(exp, actual.ToArray());
        }

        [TestMethod]
        public void SortSortedSequence()
        {
            const int count = 10000;
            var sort = new SimultaneousInsertionSort<Data>(12);
            var dataArrGen = new DataArrayGenerator();
            var sourceArr = dataArrGen.Generate(count);

            Array.Sort(sourceArr);

            var actual = sort.Sort(sourceArr);

            CollectionAssert.AreEqual(sourceArr, actual.ToArray());
        }

        [TestMethod]
        public void TestSortAnotherType()
        {
            const int count = 10000;
            var sort = new SimultaneousInsertionSort<int>(12);
            var arrGen = new ArrayGenerator();
            var sourceArr = arrGen.Generate(count);
            var exp = new int[count];
            Array.Copy(sourceArr, exp, sourceArr.Length);

            Array.Sort(exp);
            var actual = sort.Sort(sourceArr);

            CollectionAssert.AreEqual(exp, actual.ToArray());
        }
    }
}
