using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCompression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;


namespace StringCompression.Tests
{
    [TestClass()]
    public class CompressTests
    {
        [TestMethod()]
        public void CompressGivenStringTest()
        {
            string s = "aaabbbccddeeeffff";
            Compress c = new Compress();
            c.CompressGivenString(s).Should().Be("a3b3c2d2e3f4");
        }

        [TestMethod()]
        public void CompressGivenStringTestWithUniqueChars()
        {
            string s = "abcdefgh";
            Compress c = new Compress();
            c.CompressGivenString(s).Should().Be("abcdefgh");
        }

        [TestMethod()]
        public void CompressGivenStringTestWithNullInput()
        {
            string s = null;
            Compress c = new Compress();
            Action action=()=> c.CompressGivenString(s);
            action.ShouldThrow<ArgumentException>();
        }

        [TestMethod()]
        public void CompressGivenStringTestWithEmptyInput()
        {
            string s = null;
            Compress c = new Compress();
            Action action = () => c.CompressGivenString(s);
            action.ShouldThrow<ArgumentException>();
        }

        [TestMethod()]
        public void CompressGivenStringTestWithLowerAndUpperCaseLetters()
        {
            string s = "aaabbFFFAAABBB";
            Compress c = new Compress();
            c.CompressGivenString(s).Should().Be("a3b2F3A3B3");
        }

    }
}