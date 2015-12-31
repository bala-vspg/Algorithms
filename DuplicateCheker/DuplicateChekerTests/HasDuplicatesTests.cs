using Microsoft.VisualStudio.TestTools.UnitTesting;
using DuplicateCheker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace DuplicateCheker.Tests
{
    [TestClass()]
    public class HasDuplicatesTests
    {
        [TestMethod()]
        public void ContainDuplicatesTestWithDuplicates()
        {
            HasDuplicates HD=new HasDuplicates();
            HD.ContainDuplicates(new int[] {1, 2, 3, 4, 2, 3, 41, 42}).Should().Be(true);

        }

        [TestMethod()]
        public void ContainDuplicatesTestWithNoDuplicates()
        {
            HasDuplicates HD = new HasDuplicates();
            HD.ContainDuplicates(new int[] { 1, 2, 3, 4, 41, 42 }).Should().Be(false);

        }

        [TestMethod()]
        public void ContainDuplicatesTestWithEmptyArray()
        {
            HasDuplicates HD = new HasDuplicates();
            Action action = () => HD.ContainDuplicates(new int[] {});
           action.ShouldThrow<ArgumentException>();

        }

        [TestMethod()]
        public void ContainDuplicatesTestWithNullInput()
        {
            HasDuplicates HD = new HasDuplicates();
            Action action = () => HD.ContainDuplicates(null);
            action.ShouldThrow<ArgumentException>();

        }
    }
}