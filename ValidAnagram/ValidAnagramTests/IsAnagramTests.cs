using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidAnagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace ValidAnagram.Tests
{
    [TestClass()]
    public class IsAnagramTests
    {
        [TestMethod()]
        public void IsValidAnagramTest()
        {
            IsAnagram IA=new IsAnagram();
            IA.IsValidAnagram("anagram", "nagaram").Should().Be(true);

        }

        [TestMethod()]
        public void IsValidAnagramNegativeTest()
        {
            IsAnagram IA = new IsAnagram();
            IA.IsValidAnagram("rat", "cat").Should().Be(false);

        }

        [TestMethod()]
        public void IsValidAnagramTestWithNullInput()
        {
            IsAnagram IA = new IsAnagram();
            Action action=()=>IA.IsValidAnagram("rat", null);
            action.ShouldThrow<ArgumentException>();

        }

        [TestMethod()]
        public void IsValidAnagramTestWithEmptyInput()
        {
            IsAnagram IA = new IsAnagram();
            Action action = () => IA.IsValidAnagram(string.Empty, string.Empty);
            action.ShouldThrow<ArgumentException>();

        }

        [TestMethod()]
        public void IsValidAnagramTestWithStringsOfDifferentLength()
        {
            IsAnagram IA = new IsAnagram();
            IA.IsValidAnagram("rat", "cats").Should().Be(false);

        }
        [TestMethod()]
        public void IsValidAnagramTestWithequalStrings()
        {
            IsAnagram IA = new IsAnagram();
            IA.IsValidAnagram("rat", "rat").Should().Be(true);

        }
    }
}