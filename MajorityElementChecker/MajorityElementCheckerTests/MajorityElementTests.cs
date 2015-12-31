using Microsoft.VisualStudio.TestTools.UnitTesting;
using MajorityElementChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace MajorityElementChecker.Tests
{
    [TestClass()]
    public class MajorityElementTests
    {
        [TestMethod()]
        public void FindMajorityElementTest()
        {
            MajorityElement ME=new MajorityElement();
            ME.FindMajorityElement(new int[] {4, 4, 3, 5, 4, 4, 6, 7,4,4}).Should().Be(4);
        }
    }
}