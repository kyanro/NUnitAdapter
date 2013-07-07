using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using AspTesting.Tests;

namespace ASPTesting.Tests.UnitTests
{
    [TestFixture]
    public class TestFixture : AspFixture
    {
        [Test]
        public void Test()
        {
            RunAspTest("failed.html");
        }
    }
}
