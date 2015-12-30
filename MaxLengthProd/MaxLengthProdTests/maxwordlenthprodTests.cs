using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxLengthProd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace MaxLengthProd.Tests
{
    [TestClass()]
    public class maxwordlenthprodTests
    {
        [TestMethod()]
        public void findmaxlenprodHappyTest1()
        {
            maxwordlenthprod MLP =new maxwordlenthprod();
            MLP.findmaxlenprod(new string[] {"abcw", "baz", "foo", "bar", "xtfn", "abcdef"}).Should().Be(16);
        }

        [TestMethod()]
        public void findmaxlenprodHappyTest2()
        {
            maxwordlenthprod MLP = new maxwordlenthprod();
            MLP.findmaxlenprod(new string[] { "a", "ab", "abc", "d", "cd", "bcd", "abcd" }).Should().Be(4);
        }

        [TestMethod()]
        public void findmaxlenprodwithCommonLettersinAllWords()
        {
            maxwordlenthprod MLP = new maxwordlenthprod();
            MLP.findmaxlenprod(new string[] { "a", "aa", "aaa", "aaaa" }).Should().Be(0);
        }
    }
}