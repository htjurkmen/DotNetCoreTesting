using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi1.Controllers;

namespace WebApi1.Tests
{
    public class ValuesControllerTests
    {
        [TestCase]
        public void GetTest() {
            ValuesController contr = new ValuesController();
            var result = contr.Get(1);
            Assert.AreEqual("value", result);
        }
    }
}
